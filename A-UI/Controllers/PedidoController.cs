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
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService service;
        private readonly IMapper mapper;

        public PedidoController(IPedidoService service, IMapper mapper )
        {
            this.service = service;
            this.mapper = mapper;
        }

      
        [HttpGet]
        public ActionResult Get()
        {
              var ProdListBD = this.service.GetList().ToList();

            var ProdListVM = this.mapper.Map<List<Pedido>,List<PedidoVM>>(ProdListBD);
            return Ok(ProdListVM);
        }

        [HttpPut]
        public ActionResult Put(PedidoVM pedidoVM)
        {
            var PedidoModel = this.mapper.Map<PedidoVM,Pedido>(pedidoVM);

            this.service.Update(PedidoModel);
            if (this.service.SaveChanges())
                return Ok("Alterou");

            return Ok("Nao Alterou");
        }

        [HttpPost]
        public ActionResult Post(PedidoVM pedidoVM)
        {
            var PedidoModel = this.mapper.Map<PedidoVM,Pedido>(pedidoVM);
            this.service.Add(PedidoModel);
            if (this.service.SaveChanges())
                return Ok("Gravou");

            return Ok("Nao Gravou");
        }

        [HttpDelete("{Id:int}")]
        public ActionResult Delete(int Id)
        {
             var Pedido = this.service.GetList().Where(x => x.Id == Id).FirstOrDefault();
            this.service.Delete(Pedido);
            if (this.service.SaveChanges())
                return Ok("Deletou");

            return Ok("Nao Deletou");
        }
    }
}
