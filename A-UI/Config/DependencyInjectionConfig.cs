using System;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.B_BLL.Service;
using CoverAll_API.B_Service;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CoverAll_API.A_UI.Config
{
    public class DependencyInjectionConfig
    {
        public static void DependencyInjection(IServiceCollection services)
        {
            //Services
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ILoginService, LoginService>();

            //Repository
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();

        }

    }
}
