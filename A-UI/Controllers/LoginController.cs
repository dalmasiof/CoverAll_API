using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoverAll_API.A_UI.ViewModel;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.C_DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoverAll_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService service;
        private readonly IMapper mapper;

        public LoginController(ILoginService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpPost("Auth")]
        public ActionResult LogIn(LoginVM loginVM)
        {
            Cliente Login = this.service.LogIn(loginVM.Usuario, loginVM.Senha);

            if (Login == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(Login);
            }
        }

        [HttpPut]
        public ActionResult Put(LoginVM loginVM)
        {
            var Login = this.mapper.Map<LoginVM, Login>(loginVM);
            this.service.Update(Login);

            if (this.service.SaveChanges())
                return Ok("Alterou");

            return Ok("Nao alterou");

        }

        [HttpPost]
        public ActionResult Post(LoginVM loginVM)
        {
            var Login = this.mapper.Map<LoginVM, Login>(loginVM);
            this.service.Add(Login);

            if (this.service.SaveChanges())
                return Ok("Gravou");

            return Ok("Nao gravou");
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok();
        }
    }
}
