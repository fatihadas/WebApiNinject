using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiNinject.Controllers
{
    public class UserController : ApiController
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public HttpResponseMessage GetUserFullNames()
        {
            var response = _userService.GetUserFullNames();
            return Request.CreateResponse(response);
        }

    }
}
