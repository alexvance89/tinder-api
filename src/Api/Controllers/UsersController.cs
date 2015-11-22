using System;
using System.Threading.Tasks;
using System.Web.Http;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Controllers
{
    public sealed class UsersController : ApiController
    {
        private readonly IUsersApplication _usersApplication;
        private readonly IUserMapper _userMapper;

        public UsersController(IUsersApplication usersApplication, IUserMapper usersMapper)
        {
            _usersApplication = usersApplication;
            _userMapper = usersMapper;
        }

        [Route("api/users/{userId}")]
        public async Task<IHttpActionResult> Get(long userId)
        {
            IHttpActionResult result;

            try
            {
                var model = await _usersApplication.Get(userId);

                if (model != null)
                {
                    var contract = _userMapper.ToContract(model);

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
    }
}