using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverAll_API.A_UI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoverAll_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        public PedidoController()
        {
        }

      
        [HttpGet]
        public ActionResult Get()
        {
            var PedidoMock = new PedidoVM(){
                Id = 1,
                Desconto = 10.50M,
                Frete = 15,
                IdCliente = 1,
                IdProdutoCliente=2,
                StatusPedido = "A Caminho",
                StatusPagamento = "Aprovado",
                StatusEntrega = "Em trânsito",
                Total = 120
            };

            return Ok(PedidoMock);
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
