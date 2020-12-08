using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aulao
{
    class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        //ligação com a base de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GIKVBL1B\\SQLEXPRESS;" +
                "Initial Catalog=Aula1DB;Integrated Security=True");


        }

        //opção hasData para popular a base de dados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 10,
                Nome = "Etiquetas",
                Preco = 10.99M,
                Stock = 11
            });
        }
    }
}
