using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RelacionamentoEntreEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            //IncluirAutor();

            //IncluirAutorLivros();

            //IncluirAtutorLivrosAddRange();

            //IncluirNovoLivroAutor();

            //IncluirLivroAutor_ForeinKey();

            //using (var dbcontext = new AppContext())
            //{
            //    Console.Write("Nome autor: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Sobrenome autor: ");
            //    string sobrenome = Console.ReadLine();
            //    Console.Write("Quantos livros tem o autor: ");
            //    int qta = int.Parse(Console.ReadLine());
            //    var livros = new List<Livro>();
            //    for (int i = 1; i <= qta; i++)
            //    {
            //        Console.Write($"Livro {i} ");
            //        Console.Write("Titulo: ");
            //        string titulo = Console.ReadLine();
            //        Console.Write("Ano: ");
            //        int ano = int.Parse(Console.ReadLine());
            //        livros.Add(new Livro(titulo, ano));
            //    }
            //    var autor = new Autor(nome, sobrenome) { Livros = new List<Livro>(livros) };

            //    dbcontext.Add(autor);
            //    dbcontext.SaveChanges();
            //}






            using (var contexto = new AppContext())
            {
                //ExplicitLoad(contexto);
                var autor = contexto.Autores.Where(a => a.Nome == "Joao").FirstOrDefault();


                contexto.Entry(autor).Collection(l => l.Livros).Query().Where(lv => lv.AnoLancamento > 1980).Load();

                var count = contexto.Entry(autor).Collection(l => l.Livros).Query().Count();

                Console.WriteLine("Qta = " + count);
                Console.WriteLine(autor.Nome);
                foreach (var item in autor.Livros)
                {
                    Console.WriteLine($"\t {item.Titulo}");
                }
            };
            Console.ReadLine();
             


        }

        private static void ExplicitLoad(AppContext contexto)
        {
            var autor = contexto.Autores.Where(a => a.Nome == "Joao").FirstOrDefault();
            Console.WriteLine(autor.Nome);

            contexto.Entry(autor).Collection(l => l.Livros).Load();
            foreach (var item in autor.Livros)
            {
                Console.WriteLine($"\t {item.Titulo}");
            }
        }

        private static void IncluirLivroAutor_ForeinKey()
        {
            using (var dbcontext = new AppContext())
            {
                var livro = new Livro()
                {
                    Titulo = "Este é novo, MAIS",
                    AnoLancamento = 2016,
                    AutorId = 3
                };
                dbcontext.Add(livro);
                dbcontext.SaveChanges();
            }
            
        }

        private static void IncluirNovoLivroAutor()
        {
            using (var dbcontext = new AppContext())
            {
                var autor = dbcontext.Autores.Find(2);

                var Novolivro = new Livro() { Titulo = "Python", AnoLancamento = 2015, Autor = autor };

                dbcontext.Add(Novolivro);
                dbcontext.SaveChanges();
            }
        }

        private static void IncluirAtutorLivrosAddRange()
        {
            using (var dbcontext = new AppContext())
            {
                var autor = new Autor()
                {
                    Nome = "Maria",
                    SobreNome = "Silva",
                };
                var Livros = new List<Livro>()
                    {
                        new Livro{ Titulo="Judas", AnoLancamento=1989, Autor = autor },
                        new Livro{ Titulo="O bando dos 4", AnoLancamento=2001, Autor = autor },
                        new Livro{ Titulo="Alice e os Pais", AnoLancamento=1989, Autor = autor },
                    };
                dbcontext.AddRange(Livros);
                dbcontext.SaveChanges();

            };
        }


        private static void IncluirAutorLivros()
        {
            using (var dbcontext = new AppContext())
            {
                var autor = new Autor()
                {
                    Nome = "Joao",
                    SobreNome = "Machado",
                    Livros = new List<Livro>
                    {
                        new Livro { Titulo = "Manual c#", AnoLancamento = 2000, },
                        new Livro { Titulo = "Manual ASP.NET", AnoLancamento = 2020, }
                    }
                };

                dbcontext.Autores.Add(autor);
                dbcontext.SaveChanges();

            };
        }


        private static void IncluirAutor()
        {
            using (var dbcontext = new AppContext())
            {
                var autor = new Autor()
                {
                    Nome = "Agatha",
                    SobreNome = "Machado"
                };
                dbcontext.Autores.Add(autor);
                dbcontext.SaveChanges();
            }
        }
    }
}
