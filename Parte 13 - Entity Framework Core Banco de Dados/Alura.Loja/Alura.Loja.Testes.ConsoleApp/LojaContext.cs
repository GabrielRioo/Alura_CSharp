﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public LojaContext()
        {
        }
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {
        }

        // classes que vai ser persistida pelo entity
        // DbSet - representa o conjunto de objetos da classe
        // Produtos = nome da tabela no banco de dados
        public DbSet<Produto> Produtos { get; set; }



        // definir o banco de dados e onde ele fica - Evento de configuração
        // sobreeescrever um metodo da classe DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // construtor de opçoes
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }
        }
    }
}