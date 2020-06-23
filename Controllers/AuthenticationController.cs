using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEntityApi.Model.Common;
using CoreEntityApi.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CoreEntityApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateService _authenticateService;
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] User Model)
        {
            var user = _authenticateService.Authenticate(Model.UserName, Model.Password);



            if (user == null)
            {
                return BadRequest(new { message = "Username or Password is incorrect" });



            }
            else
            {
                return Ok(user);
            }
        }
    }
}