using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace MuitosParaMuitos
{
    public class AppDbContext2 : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlunoCurso> AlunosCursos { get; set; }


        //ligação com a base de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GIKVBL1B\\SQLEXPRESS;" +
                "Initial Catalog=Aula2DB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoCurso>().HasKey(sc => new { sc.AlunoId, sc.CursoId });
        }
    }
}
