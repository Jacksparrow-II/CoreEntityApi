using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CoreEntityApi.Model.Entity;
using CoreEntityApi.Repository.Interface;

namespace CoreEntityApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _ILogin;
        public LoginController(ILogin LoginRepo)
        {
            _ILogin = LoginRepo;
        }

        [HttpPost("GetLogin")]
        public int GetLogin([FromBody] Registration Registration, int Id, string UserName)
        {
            //**** move this below code to dependency injection ****
            return _ILogin.GetLogin(Registration, Id, UserName);
        }
    }
}