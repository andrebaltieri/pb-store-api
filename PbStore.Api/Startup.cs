using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PbStore.Domain.Pedidos.Comandos;
using PbStore.Domain.Pedidos.Repositorios;
using PbStore.Infra.Contexts;
using PbStore.Infra.Repositorios;

namespace PbStore.Api
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<PbStoreDataContext, PbStoreDataContext>();
            services.AddTransient<IRepositorioPedido, RepositorioPedido>();
            services.AddTransient<IRepositorioProduto, RepositorioProduto>();
            services.AddTransient<IRepositorioCliente, RepositorioCliente>();
            services.AddTransient<ManipuladorPedidos, ManipuladorPedidos>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();
        }
    }
}
