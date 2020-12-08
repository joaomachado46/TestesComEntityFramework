using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aulao
{
    class ChangeTracker
    {
        private static void ExibirEstado(IEnumerable<EntityEntry> entries)
        {
            foreach (var item in entries)
            {
                Console.WriteLine($"Estado da entidade: {item.State.ToString()}");
            }
        }

        public static void ChangeTrackerMetodos(AppDbContext dbContext)
        {
            if (!dbContext.Produtos.Any())
            {
                Console.WriteLine("1- Carga Inicial");
                var produtos = dbContext.Produtos;
                foreach (var item in produtos)
                {
                    System.Console.WriteLine(item.Nome);
                }
                ExibirEstado(dbContext.ChangeTracker.Entries());

                ///aqui estou a adicionar um nov produto e com isso vai me dar uma mudança de estado para
                ///added.
                ///
                Console.WriteLine("PRODUTO NOVO");
                var produtoNovo = new Produto();
                produtoNovo.Nome = "Mochila Mikey";
                produtoNovo.Preco = 55.99M;
                produtoNovo.Stock = 10;

                dbContext.Add(produtoNovo);
                dbContext.SaveChanges();

                foreach (var item in produtos)
                {
                    System.Console.WriteLine(item.Nome);
                }
                ExibirEstado(dbContext.ChangeTracker.Entries());

                ///Aqui vou modificar um produto existente
                ///
                Console.WriteLine("ALTERAR PRODUTO:");
                var produtoAlterado = dbContext.Produtos.First();
                produtoAlterado.Nome = "Novo Produto Mikey";

                dbContext.SaveChanges();

                ExibirEstado(dbContext.ChangeTracker.Entries());

                ///Aqui vou eliminar um produto
                ///
                Console.WriteLine("ELIMAR UM PRODUTO:");
                var deleteProduto = dbContext.Produtos.Find(134);
                dbContext.Remove(deleteProduto);

                dbContext.SaveChanges();

                ExibirEstado(dbContext.ChangeTracker.Entries());

                ///aqui vou alterar o estado da entidade direto para o que eu quero
                Console.WriteLine("ALTERAR NA ENTIDADE DIRETAMENTE:");
                var produtoAlte = dbContext.Produtos.Find(135);
                dbContext.Entry(produtoAlte).State = EntityState.Modified;

                ExibirEstado(dbContext.ChangeTracker.Entries());
            }
        }
    }
}
