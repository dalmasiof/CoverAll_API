namespace CoverAll_API.A_UI.ViewModel
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

     

    }
}