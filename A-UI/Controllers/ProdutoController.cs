using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoverAll_API.A_UI.ViewModel;
using CoverAll_API.C_DAL.Model;
using CoverAll_API.B_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace CoverAll_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]

    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoService produtoService;
        private readonly IMapper mapper;



        public ProdutoController(IProdutoService produtoService, IMapper mapper)
        {
            this.produtoService = produtoService;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var ProdListBD = this.produtoService.GetList().ToList();

            var ProdListVM = this.mapper.Map<List<Produto>, List<ProdutoVM>>(ProdListBD);
            return Ok(ProdListVM);
        }

        [HttpPut]
        public ActionResult Put(ProdutoVM produto)
        {
            var ProdutoModel = this.mapper.Map<ProdutoVM, Produto>(produto);

            this.produtoService.Update(ProdutoModel);
            if (this.produtoService.SaveChanges())
                return Ok();

            return Ok();
        }

        [HttpPost]
        public ActionResult Post(ProdutoVM produto)
        {
//
            var ProdutoModel = this.mapper.Map<ProdutoVM, Produto>(produto);

            this.produtoService.Add(ProdutoModel);
            if (this.produtoService.SaveChanges())
                return Ok();

            return Ok();
        }

        [HttpDelete("{Id:int}")]
        public ActionResult Delete(int Id)
        {
            var Produto = this.produtoService.GetList().Where(x => x.Id == Id).FirstOrDefault();
            this.produtoService.Delete(Produto);
            if (this.produtoService.SaveChanges())
                return Ok();

            return Ok();
        }
    }
}
