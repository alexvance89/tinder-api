using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Tinder.Api.Filters;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Controllers
{
    public sealed class DiscoveriesController : ApiController
    {
        private readonly IDiscoveriesApplication _discoveriesApplication;
        private readonly IDiscoveryMapper _discoveryMapper;

        public DiscoveriesController(IDiscoveriesApplication discoveriesApplication, IDiscoveryMapper discoveryMapper)
        {
            _discoveriesApplication = discoveriesApplication;
            _discoveryMapper = discoveryMapper;
        }

        /// <summary>
        /// Gets the discovered users for the currently authenticated user.
        /// </summary>
        [DeflateCompression]
        public async Task<IHttpActionResult> Get()
        {
            IHttpActionResult result;

            try
            {
                var currentUserId = default(long);
                var models = await _discoveriesApplication.GetDiscoveries(currentUserId);

                if (models != null)
                {
                    var contracts = models.Select(_discoveryMapper.ToContract).ToList();

                    if (contracts.Any())
                    {
                        result = Ok(contracts);
                    }
                    else
                    {
                        result = NotFound();
                    }
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
        /// Likes the specified user.
        /// </summary>
        [HttpPost]
        [Route("api/discoveries/like/{userId}")]
        public IHttpActionResult Like(long userId)
        {
            IHttpActionResult result;

            try
            {
                var currentUserId = default(long);

                _discoveriesApplication.Like(currentUserId, userId);

                result = StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception e)
            {
                result = InternalServerError(e);
            }

            return result;
        }

        /// <summary>
        /// Dislikes the specified user.
        /// </summary>
        [HttpPost]
        [Route("api/discoveries/dislike/{userId}")]
        public IHttpActionResult Dislike(long userId)
        {
            IHttpActionResult result;

            try
            {
                var currentUserId = default(long);

                _discoveriesApplication.Dislike(currentUserId, userId);

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
