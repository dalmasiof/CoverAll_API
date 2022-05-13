using System;
using CoverAll_API.B_Service;
using CoverAll_API.C_DAL.Interface;
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

             //Repository
             services.AddScoped<IProdutoRepository, ProdutoRepository>();
         }   

         
    
    }
}
