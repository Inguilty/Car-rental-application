using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AspNetIdentity.Logic.Shared.Interfaces;

namespace Services.Api.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public async Task<HttpResponseMessage> Get()
        {
            try
            {
                var result = await _userRepository.GetUsersAsync();
                if (!result.Any())
                {
                    Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Could not retrieve users.");
            }
        }
        public async Task<HttpResponseMessage> Get(int id)
        {
            try
            {
                var result = await _userRepository.GetUserByIdAsync(id);
                if (result == null)
                {
                    Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Could not retrieve users.");
            }
        }
    }
}