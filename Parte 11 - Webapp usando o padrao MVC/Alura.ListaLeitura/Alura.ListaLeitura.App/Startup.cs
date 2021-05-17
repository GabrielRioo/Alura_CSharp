﻿using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(Roteamento);
        }

        public Task Roteamento(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            var caminhosAtendidos = new Dictionary<string, string>
            {
                { "/Livros/ParaLer", _repo.ParaLer.ToString() },
                { "/Livros/Lendo", _repo.ParaLer.ToString() },
                { "/Livros/Lidos", _repo.ParaLer.ToString() }
            };

            if (caminhosAtendidos.ContainsKey(context.Request.Path))
            {
                return context.Response.WriteAsync(caminhosAtendidos[context.Request.Path]);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Caminho inexistente.");
        }

        public Task LivrosParaLer(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.ParaLer.ToString());
        }
    }
}