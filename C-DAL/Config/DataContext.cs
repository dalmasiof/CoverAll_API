using CoverAll_API.C_DAL.Model.Cliente;
using Microsoft.EntityFrameworkCore;

namespace CoverAll_API.C_DAL.Config
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //  protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite("Data Source=entertainment.db");

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }

}
