using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aulao
{
    class ImprimirDataBase
    {
        public static void ExibirDadosDaBaseDados(AppDbContext db)
        {
            var produtos = db.Produtos.ToList();
            foreach (var obj in produtos)
            {
                Console.WriteLine(obj.ProdutoId + ": NOME: " + obj.Nome + ", PREÇO: " + obj.Preco + ", STOCK: " + obj.Stock);
            }
        }
    }
}
