using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoverAll_API.A_UI.ViewModel;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.C_DAL.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoverAll_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]

    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;
        private readonly IMapper mapper;
        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            this.clienteService = clienteService;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var ClienteListBD = this.clienteService.GetList().ToList();

            var ClienteVM = this.mapper.Map<List<Cliente>, List<ClienteVM>>(ClienteListBD);
            return Ok(ClienteVM);
        }

        [HttpPut]
        public ActionResult Put(ClienteVM clienteVM)
        {
            var ClienteModel = this.mapper.Map<ClienteVM, Cliente>(clienteVM);

            this.clienteService.Update(ClienteModel);
            if (this.clienteService.SaveChanges())
                return Ok("Alterou");

            return Ok("Nao Alterou");
        }

        [HttpPost]
        public ActionResult Post(ClienteVM clienteVM)
        {

            var ClienteModel = this.mapper.Map<ClienteVM, Cliente>(clienteVM);

            this.clienteService.Add(ClienteModel);
            if (this.clienteService.SaveChanges())
                return Ok("Gravou");

            return Ok("Nao Gravou");
        }

        [HttpDelete("{Id:int}")]
        public ActionResult Delete(int Id)
        {
            var Cliente = this.clienteService.GetList().Where(x => x.Id == Id).FirstOrDefault();
            this.clienteService.Delete(Cliente);
            if (this.clienteService.SaveChanges())
                return Ok("Deletou");

            return Ok("Nao Deletou");
        }
    }
}
