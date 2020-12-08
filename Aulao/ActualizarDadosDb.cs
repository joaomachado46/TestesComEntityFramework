using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aulao
{
    class ActualizarDadosDb
    {
        public static void UpdateBd(AppDbContext context)
        {
            if (!context.Produtos.Any())
            {
                Console.Write("Nome a alterar: ");
                string nome = Console.ReadLine();

                var dados = context.Produtos.First(produto => produto.Nome == nome);
                Console.Write("Novo nome: ");
                nome = Console.ReadLine();
                dados.Nome = nome;
                dados.Stock = 200;

                context.SaveChanges();
            }
        }
    }
}
