using System;
using System.Collections.Generic;
using System.Text;

namespace FluentAPI
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }

    }
}
