using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aulao
{
    class PopularBDcomCode
    {
        //Opção para popular base de dados, ex: com construtor da class Produto
        public static void SeedData(AppDbContext context) //string nome, decimal preco, int stock//
        {
            if (!context.Produtos.Any())
            {
                var produtos = new List<Produto>
                {
                   new Produto {Nome = "Caneta", Preco = 10.99M, Stock= 100},
                   new Produto {Nome = "Lapis", Preco = 10.99M, Stock= 100},
                   new Produto {Nome = "Estojo", Preco = 10.99M, Stock= 100},

                   //new Produto (nome,preco,stock),
                };
                context.AddRange(produtos);
                context.SaveChanges();
            }
        }
    }
}
