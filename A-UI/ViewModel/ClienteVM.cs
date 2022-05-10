using System;

namespace CoverAll_API.A_UI.ViewModel
{
    public class ClienteVM
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Genero { get; set; }
        public string email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco  { get; set; }
        public string Cidade  { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}