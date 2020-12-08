using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace MuitosParaMuitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complete");

            using (var contexto = new AppDbContext2())
            {
                //contexto.Database.EnsureDeleted();
                //contexto.Database.EnsureCreated();

                //var curso = new[]
                //{
                //   new Curso{ CursoNome = "c#", Descricao="Curso c#"},
                //   new Curso{ CursoNome = "Java#", Descricao="Curso Java#"},
                //   new Curso{ CursoNome = "Ado#", Descricao="Curso Ado#"},
                //   new Curso{ CursoNome = "Python#", Descricao="Curso Python#"},
                //};
                //var alunos = new[]
                //{
                //    new Aluno { Nome = "Maria"},
                //    new Aluno { Nome = "Joao"},
                //    new Aluno { Nome = "Vania"},
                //    new Aluno { Nome = "Francisca"},

                //};
                //contexto.AddRange(
                //    new AlunoCurso { Curso = curso[0], Aluno = alunos[0] },
                //    new AlunoCurso { Curso = curso[0], Aluno = alunos[1] },
                //    new AlunoCurso { Curso = curso[1], Aluno = alunos[2] },
                //    new AlunoCurso { Curso = curso[1], Aluno = alunos[3] },
                //    new AlunoCurso { Curso = curso[2], Aluno = alunos[0] },
                //    new AlunoCurso { Curso = curso[2], Aluno = alunos[1] },
                //    new AlunoCurso { Curso = curso[3], Aluno = alunos[2] },
                //    new AlunoCurso { Curso = curso[3], Aluno = alunos[3] }
                //);
                //contexto.SaveChanges();
                //Console.WriteLine("Complete");


                var alunos = contexto.Alunos
                    .Include(e => e.AlunoCursos)
                    .ThenInclude(e => e.Curso)
                    .ToList();

                foreach (var aluno1 in alunos)
                {
                    Console.WriteLine("Aluno: " + aluno1.Nome );
                    foreach (var curso in aluno1.AlunoCursos.Select(e => e.Curso))
                    {
                        Console.WriteLine("        Curso: " + curso.CursoNome);
                    }
                }

                var aluno = contexto.Alunos.First();

                var alunoscursos = contexto.AlunosCursos
                    .Where(x => x.AlunoId == aluno.Id)
                    .Include(c => c.Curso);

                Console.WriteLine("Curso para o aluno: " + aluno.Id +", "+ aluno.Nome);

                foreach (var obj in alunoscursos)
                {
                    Console.WriteLine("    " + obj.Curso.CursoNome);
                }

            };
            Console.WriteLine("Complete");
        }
    }
}
