﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            AdicionarProduto();
            ConsultarProduto();
            ExcluirProdutos();
            ConsultarProduto();

        }

        private static void ExcluirProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        private static void ConsultarProduto()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Console.WriteLine($"Foram encontrados: {produtos.Count} produtos");
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void AdicionarProduto()
        {
            Produto p = new Produto();
            p.Nome = "Gabriel";
            p.Categoria = "Pessoa";
            p.Preco = 9999.99;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}