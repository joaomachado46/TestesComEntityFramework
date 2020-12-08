using System;
using System.Collections.Generic;
using System.Text;

namespace Aulao
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, decimal preco, int stock)
        {
            Nome = nome;
            Preco = preco;
            Stock = stock;
        }
    }
}
