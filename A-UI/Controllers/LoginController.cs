using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoverAll_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
       public LoginController(){
        }

      
        [HttpGet]
        public ActionResult LogIn()
        {
            return Ok("Get Login");
        }

        [HttpPut]
        public ActionResult Put()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post()
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok();
        }
    }
}
