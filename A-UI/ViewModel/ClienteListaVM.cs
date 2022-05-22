using System;

namespace CoverAll_API.A_UI.ViewModel
{
    public class ClienteListaVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string email { get; set; }

        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}
