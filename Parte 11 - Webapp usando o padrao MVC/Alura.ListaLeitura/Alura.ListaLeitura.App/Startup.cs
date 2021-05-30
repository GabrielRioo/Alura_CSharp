﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRouting(); // serviço de roteamento do asp net core.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage(); // apenas utilizar em modo de desenvolvimento
            app.UseMvcWithDefaultRoute();
            //var builder = new RouteBuilder(app);
            //builder.MapRoute("{controller}/{action}", RoteamentoPadrao.TratamentoPadrao);
            //builder.MapRoute("Livros/Lidos", LivrosLogica.Lidos);
            //builder.MapRoute("Livros/ParaLer", LivrosLogica.ParaLer);
            //builder.MapRoute("Livros/Lendo", LivrosLogica.Lendo);

            //builder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.Detalhes); // adicionando uma constraint, restrição de tipo.
            //builder.MapRoute("Livros/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro); // rota com template usando dois seguimentos
            //builder.MapRoute("Cadastro/ExibeFormulario", CadastroLogica.ExibeFormulario);
            //builder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);

            //var rotas = builder.Build();
            //app.UseRouter(rotas);

            //app.Run(Roteamento);
        }

       

        // Roteamento mais rudimentar, usando dicionario.
        //public Task Roteamento(HttpContext context)
        //{
        //    var _repo = new LivroRepositorioCSV();
        //    var caminhosAtendidos = new Dictionary<string, RequestDelegate>
        //    {
        //        { "/Livros/ParaLer", LivrosParaLer },
        //        { "/Livros/Lendo", LivrosLendo },
        //        { "/Livros/Lidos", LivrosLidos }
        //    };

        //    if (caminhosAtendidos.ContainsKey(context.Request.Path))
        //    {
        //        var metodo = caminhosAtendidos[context.Request.Path];
        //        return metodo.Invoke(context);
        //    }

        //    context.Response.StatusCode = 404;
        //    return context.Response.WriteAsync("Caminho inexistente.");
        //}
    }
}