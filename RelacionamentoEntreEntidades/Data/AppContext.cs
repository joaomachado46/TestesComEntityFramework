using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoEntreEntidades
{
    public class AppContext : DbContext
    {
        /// <summary>
        /// Entidades para declarar que vai ser introduzida na BD
        /// </summary>
       
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }

        //ligação com a base de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=LAPTOP-GIKVBL1B\\SQLEXPRESS;" +
                "Initial Catalog=Aula2RelacimentoBD;Integrated Security=True");

        }

        //opção hasData para popular a base de dados atraves de migracions, depois na migracion defino o que quero
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 60,
                Nome = "MochilaNova",
                Preco = 10.99M,
                Stock = 25
            });
        }*/
    }
}
