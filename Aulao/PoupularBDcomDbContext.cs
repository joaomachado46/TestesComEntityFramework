using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aulao
{
    class PoupularBDcomDbContext
    {

        public static void PopularBdcomDbContext(AppDbContext context)
        {
            if (!context.Produtos.Any())
            {
                var produtoNovo = new Produto();
                produtoNovo.Nome = "Caneta Azul";
                produtoNovo.Preco = 10.99M;
                produtoNovo.Stock = 100;

                context.Add(produtoNovo);
                context.SaveChanges();
            }
        }
        public static void PopularBdcomDbContextLIST(AppDbContext context)
        {
            if (!context.Produtos.Any())
            {
                var listaProdutos = new List<Produto>
                {
                    new Produto{ Nome = "Caneta Vermelha ", Preco = 12.99M, Stock = 100},
                    new Produto{ Nome = "Caneta Azul ", Preco = 12.99M, Stock = 100},
                    new Produto{ Nome = "Caneta Preta ", Preco = 12.99M, Stock = 100},
                };
                context.AddRange(listaProdutos);
                context.SaveChanges();
            }
        }
    }
}

