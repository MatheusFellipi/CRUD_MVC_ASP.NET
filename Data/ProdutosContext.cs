using System;
using System.Collections.Generic;
using MVC__CRUD_TESTE.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC__CRUD_TESTE.Data
{
    public class ProdutosContext : DbContext
    {
        public ProdutosContext(DbContextOptions<ProdutosContext> options) : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>().ToTable("Produtos");

        }
    }
}