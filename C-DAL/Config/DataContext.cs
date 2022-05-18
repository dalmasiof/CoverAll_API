using CoverAll_API.C_DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace CoverAll_API.C_DAL.Config
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Produtos = new Produto[]{
            new Produto{Cor="Vermelho",Descricao="Tecido Vermelho",Id=1,Observacao="",Preco=45.00M,Quantidade=10,Tamanho="XG"},
            new Produto{Cor="Azul",Descricao="Tecido Azul Escuro",Id=2,Observacao="",Preco=55.00M,Quantidade=20,Tamanho="GG"},
            new Produto{Cor="Preto",Descricao="Camisa manga longa",Id=3,Observacao="Desenvolvido para manter a temperatura corporal",Preco=415.00M,Quantidade=5,Tamanho="XXG"}
            };

            var Clientes = new Cliente[]{
            new Cliente{Id=1,CEP="05668545",Cidade="São Paulo",CPF="447.649.596-66",DataNascimento= System.DateTime.Parse("1978-05-14"),email="eduardo_noah_ramos@trimempresas.com.br",Endereco= "Rua Pio XII",Genero="Masculino",Nome="Eduardo",Sobrenome="Noah Ramos",Telefone="88 3889-3701",UF="CE" }
            };

            var Login = new Login[]{
            new Login{Id=1,IdCLiente=1,Senha="admin",Usuario="admin"}
            };

            modelBuilder.Entity<Produto>().HasData(Produtos);
            modelBuilder.Entity<Cliente>().HasData(Clientes);
            modelBuilder.Entity<Login>().HasData(Login);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }

}
