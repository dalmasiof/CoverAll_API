using System.Collections.Generic;

namespace CoverAll_API.C_DAL.Model.Cliente
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProdutoCliente { get; set; }
        public decimal Total { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal TotalAPagar { get; set; }
        public string StatusPedido { get; set; }
        public string StatusPagamento { get; set; }
        public string StatusEntrega { get; set; }

        public ICollection<Produto> Produtos { get; set; }



    }
}