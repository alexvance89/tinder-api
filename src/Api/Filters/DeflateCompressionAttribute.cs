using System.IO;
using System.Net.Http;
using System.Web.Http.Filters;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using Ionic.Zlib;

namespace Tinder.Api.Filters
{
    public sealed class DeflateCompressionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var content = actionExecutedContext.Response.Content;
            var bytes = content?.ReadAsByteArrayAsync().Result;
            var compressedContent = Deflate(bytes);

            actionExecutedContext.Response.Content = new ByteArrayContent(compressedContent);
            actionExecutedContext.Response.Headers.Remove("Content-Type");
            actionExecutedContext.Response.Content.Headers.Add("Content-encoding", "deflate");
            actionExecutedContext.Response.Content.Headers.Add("Content-Type", "application/json");

            base.OnActionExecuted(actionExecutedContext);
        }

        private static byte[] Deflate(byte[] bytes)
        {
            if (bytes == null) return new byte[0];

            using (var stream = new MemoryStream())
            {
                using (var compressor = new DeflateStream(stream,CompressionMode.Compress, CompressionLevel.BestSpeed))
                {
                    compressor.Write(bytes, 0, bytes.Length);
                }

                return stream.ToArray();
            }
        }
    }
}