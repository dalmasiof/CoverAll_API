using System.Collections.Generic;

namespace CoverAll_API.C_DAL.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string Observacao { get; set; }
        public string Quantidade { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}