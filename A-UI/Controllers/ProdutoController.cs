using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverAll_API.B_Service;
using CoverAll_API.C_DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoverAll_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoService produtoService;


        public ProdutoController(IProdutoService produtoService)
        {
            this.produtoService = produtoService;

        }


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this.produtoService.GetList());
        }

        [HttpPut]
        public ActionResult Put()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Produto prod)
        {
            this.produtoService.Add(prod);
            if(this.produtoService.SaveChanges())
            return Ok("Gravou");

            return Ok("Nao Gravou");
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok();
        }
    }
}
