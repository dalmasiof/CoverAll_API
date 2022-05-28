using CoverAll_API.C_DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace CoverAll_API.C_DAL.Config
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().Property(x => x.Id)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Login>().Property(x => x.Id)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Produto>().Property(x => x.Id)
            .ValueGeneratedOnAdd();
            modelBuilder.Entity<Pedido>().Property(x => x.Id)
             .ValueGeneratedOnAdd();
          


            modelBuilder.Entity<Produto>().Property(x => x.Preco).HasPrecision(5, 2);
            modelBuilder.Entity<Pedido>().Property(x => x.Frete).HasPrecision(5, 2);
            modelBuilder.Entity<Pedido>().Property(x => x.Total).HasPrecision(5, 2);
            modelBuilder.Entity<Pedido>().Property(x => x.TotalAPagar).HasPrecision(5, 2);
            modelBuilder.Entity<Pedido>().Property(x => x.Desconto).HasPrecision(5, 2);

            var Produtos = new Produto[]{
            new Produto{Cor="Vermelho",Descricao="Camiseta vermelha",Id=1,Observacao="Camiseta lisa vermelha",Preco=45.00M,Genero="M",UrlImg="prod-1.webp"},
            new Produto{Cor="Azul",Descricao="Camiseta Azul",Id=2,Observacao="Camiseta lisa azul",Preco=45.00M,Genero="M",UrlImg="prod-2.jpg"},
            new Produto{Cor="Preto",Descricao="Camiseta Preta",Id=3,Observacao="Camiseta lisa preta",Preco=55.00M,Genero="M",UrlImg="prod-3.webp"},
            new Produto{Cor="Branco",Descricao="Camiseta Branca",Id=4,Observacao="Camiseta lisa branca",Preco=55.00M,Genero="M",UrlImg="prod-4.webp"},
            new Produto{Cor="Preta",Descricao="Camiseta Preta Star wars",Id=5,Observacao="Camiseta stampada star wars",Preco=60.00M,Genero="M",UrlImg="prod-5.jpg"},
            new Produto{Cor="Preto",Descricao="Camiseta Preta Naruto",Id=6,Observacao="Camiseta stampada Naruto",Preco=55.00M,Genero="M",UrlImg="prod-6.webp"},

            new Produto{Cor="Vermelho",Descricao="Camiseta vermelha",Id=7,Observacao="Camiseta lisa vermelha",Preco=45.00M,Genero="F",UrlImg="prod-7.webp"},
            new Produto{Cor="Azul",Descricao="Camiseta Azul",Id=8,Observacao="Camiseta lisa azul",Preco=45.00M,Genero="F",UrlImg="prod-8.jpg"},
            new Produto{Cor="Preto",Descricao="Camiseta Preta",Id=9,Observacao="Camiseta lisa preta",Preco=55.00M,Genero="F",UrlImg="prod-9.webp"},
            new Produto{Cor="Branco",Descricao="Camiseta Branca",Id=10,Observacao="Camiseta lisa branca",Preco=55.00M,Genero="F",UrlImg="prod-10.webp"},
            new Produto{Cor="Preta",Descricao="Camiseta Preta Star wars",Id=11,Observacao="Camiseta stampada star wars",Preco=60.00M,Genero="F",UrlImg="prod-11.webp"},
            new Produto{Cor="Preto",Descricao="Camiseta Preta Naruto",Id=12,Observacao="Camiseta stampada Naruto",Preco=55.00M,Genero="F",UrlImg="prod-12.webp"},

            new Produto{Cor="Jeans",Descricao="Calça jeans",Id=13,Observacao="Calça jeans",Preco=100.00M,Genero="M",UrlImg="prod-13.webp"},
            new Produto{Cor="Bege",Descricao="Calça jogger",Id=14,Observacao="Calça jogger bege",Preco=125.00M,Genero="M",UrlImg="prod-14.jfif"},
            new Produto{Cor="Preto",Descricao="Calça preta sarja",Id=15,Observacao="Calça preta de sarja",Preco=110.00M,Genero="M",UrlImg="prod-15.jfif"},
            new Produto{Cor="Cinza",Descricao="Bermuda cinza",Id=16,Observacao="Bermuda cinza",Preco=65.00M,Genero="M",UrlImg="prod-16.webp"},

            new Produto{Cor="Jeans",Descricao="Calça jeans",Id=17,Observacao="Calça jeans",Preco=100.00M,Genero="F",UrlImg="prod-17.jpg"},
            new Produto{Cor="Bege",Descricao="Calça jogger",Id=18,Observacao="Calça jogger bege",Preco=125.00M,Genero="F",UrlImg="prod-18.webp"},
            new Produto{Cor="Preto",Descricao="Calça preta sarja",Id=19,Observacao="Calça preta de sarja",Preco=110.00M,Genero="F",UrlImg="prod-19.webp"},
            new Produto{Cor="Preto",Descricao="Vestido Preto",Id=20,Observacao="Vestido preto",Preco=65.00M,Genero="F",UrlImg="prod-20.webp"},


            };

            var Clientes = new Cliente[]{
            new Cliente{Id=1,CEP="05668545",Cidade="São Paulo",CPF="44764959666",DataNascimento= System.DateTime.Parse("1978-05-14"),email="eduardo_noah_ramos@trimempresas.com.br",Endereco= "Rua Pio XII",Genero="Masculino",Nome="Eduardo",Sobrenome="Noah Ramos",Telefone="88 3889-3701",UF="CE" }
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
