using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Tinder.Api.Filters;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Controllers
{
    public sealed class MatchesController : ApiController
    {
        private readonly IMatchesApplication _matchesApplication;
        private readonly IMatchMapper _matchMapper;

        public MatchesController(IMatchesApplication matchesApplication, IMatchMapper matchMapper)
        {
            _matchesApplication = matchesApplication;
            _matchMapper = matchMapper;
        }

        /// <summary>
        /// Serves up the ui for the matched users of the currently authenticated user.
        /// </summary>
        [DeflateCompression]

        public async Task<IHttpActionResult> Get()
        {
            IHttpActionResult result;

            try
            {
                var userId = default(long); //access via authorization header token;
                var models = await _matchesApplication.Get(userId);

                if (models != null)
                {
                    var contracts = models.Select(_matchMapper.ToContract).ToList();

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
    }
}