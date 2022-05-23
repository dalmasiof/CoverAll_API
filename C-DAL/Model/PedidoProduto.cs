using System;

namespace CoverAll_API.C_DAL.Model
{
    public class PedidoProduto
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public string Tamanho => Produto.Tamanho;
    }
}
