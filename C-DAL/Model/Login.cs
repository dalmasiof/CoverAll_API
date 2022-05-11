namespace CoverAll_API.C_DAL.Model
{
    public class Login
    {
        public int Id { get; set; }
        public int IdCLiente { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}