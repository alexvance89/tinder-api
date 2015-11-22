using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Jil;

namespace Tinder.Api.Configuration
{
    public sealed class JilFormatter : MediaTypeFormatter
    {
        private readonly Options _options;

        public JilFormatter()
        {
            _options = new Options(dateFormat:DateTimeFormat.ISO8601,serializationNameFormat:SerializationNameFormat.CamelCase);

            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
            SupportedEncodings.Add(new UTF8Encoding(false, true));
            SupportedEncodings.Add(new UnicodeEncoding(false, true, true));
        }

        public override bool CanReadType(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            return true;
        }

        public override bool CanWriteType(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            return true;
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            return Task.FromResult(DeserializeFromStream(type, readStream));
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            var writer = new StreamWriter(writeStream);
            JSON.Serialize(value, writer, _options);
            writer.Flush();
            return Task.FromResult(writeStream);
        }

        private object DeserializeFromStream(Type type, Stream stream)
        {
            try
            {
                using (var reader = new StreamReader(stream))
                {
                    var method = typeof(JSON).GetMethod("Deserialize", new[] { typeof(TextReader), typeof(Options)});
                    var generic = method.MakeGenericMethod(type);
                    return generic.Invoke(this, new object[] {reader, _options});
                }
            }
            catch 
            {
                return null;
            }
        }
    }
}