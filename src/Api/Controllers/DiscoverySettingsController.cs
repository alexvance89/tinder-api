using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Tinder.Api.Contracts;
using Tinder.Api.Filters;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Controllers
{
    public sealed class DiscoverySettingsController : ApiController
    {
        private readonly IDiscoverySettingsApplication _discoverySettingsApplication;
        private readonly IDiscoverySettingsMapper _discoverySettingsMapper;

        public DiscoverySettingsController(IDiscoverySettingsApplication discoverySettingsApplication, IDiscoverySettingsMapper discoverySettingsMapper)
        {
            _discoverySettingsApplication = discoverySettingsApplication;
            _discoverySettingsMapper = discoverySettingsMapper;
        }

        /// <summary>
        /// Serves up the discoverySettings view for the current authenticated user.
        /// </summary>
        [DeflateCompression]

        public async Task<IHttpActionResult> Get()
        {
            IHttpActionResult result;

            try
            {
                var userId = default(long); //access via authorization header token;
                var model = await _discoverySettingsApplication.Get(userId);

                if (model != null)
                {
                    var contract = _discoverySettingsMapper.ToContract(model);

                    result = Ok(contract);
                }
                else
                {
                    result = NotFound();
                }
            }
            catch (Exception e)
            {
                result = InternalServerError(e);
            }

            return result;
        }

        /// <summary>
        /// Allows updating the currently authenticated users discoverySettings. 
        /// </summary>
        /// <param name="contract">discoverySettings object representation.</param>
        public async Task<IHttpActionResult> Put([FromBody] DiscoverySettingsContract contract)
        {
            IHttpActionResult result;

            try
            {
                var userId = default(long); //access via authorization header token;
                var model = _discoverySettingsMapper.ToModel(contract);

                await _discoverySettingsApplication.Put(userId, model);

                result = StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                result = InternalServerError(e);
            }

            return result;
        }
    }
}