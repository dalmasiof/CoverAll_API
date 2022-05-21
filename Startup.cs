using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoverAll_API.A_UI.Config;
using CoverAll_API.C_DAL.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace CoverAll_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            //     services.AddDbContext<DataContext>(
            //        ctx =>
            //        {
            //            ctx.UseSqlite("Data Source=DataBase.db");
            //        }
            //    );

            services.AddDbContext<DataContext>(x =>
             {
                 var local = Configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT");
                 Console.Write(local);
                 Console.WriteLine("-------------Var-------------\n" + local);
                 string connStr;
                 if (local == "Development")
                 {
                     connStr = Configuration.GetConnectionString("sqlConnection");
                 }
                 else
                 {
                     // Use connection string provided at runtime by Heroku.
                     connStr = Environment.GetEnvironmentVariable("CLEARDB_DATABASE_URL");

                     var connUrl = connStr;

                     connUrl = connUrl.Replace("mysql://", string.Empty);
                     var userPassSide = connUrl.Split("@")[0];
                     var hostSide = connUrl.Split("@")[1];

                     var connUser = userPassSide.Split(":")[0];
                     var connPass = userPassSide.Split(":")[1];
                     var connHost = hostSide.Split("/")[0];
                     var connDb = hostSide.Split("/")[1].Split("?")[0];

                     connStr = $"server={connHost};Uid={connUser};Pwd={connPass};Database={connDb}";
                 }

                 Console.WriteLine("-------------Var-------------\n" + connStr);
                 x.UseMySql(connStr, new MySqlServerVersion(new Version(5, 0, 0)));

             });




            services.AddAutoMapper(typeof(Startup));


            DependencyInjectionConfig.DependencyInjection(services);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CoverAll_API", Version = "v1" });
            });


        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CoverAll_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
