using System.Collections.Generic;

namespace CoverAll_API.C_DAL.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public decimal Total { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal TotalAPagar { get; set; }
        public string StatusPedido { get; set; }
        public string StatusPagamento { get; set; }
        public string StatusEntrega { get; set; }
        public string Tamanho { get; set; }
        public string EnderecoEntrega { get; set; }


        public ICollection<Produto> Produtos { get; set; }



    }
}