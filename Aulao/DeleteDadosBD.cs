using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aulao
{
    class DeleteDadosBD
    {

        public static void DeletarDadocomDbSet(AppDbContext context)
        {
            if (!context.Produtos.Any())
            {
                var dados = from p in context.Produtos
                            where p.ProdutoId == 133 
                            select p;
                //var produto = context.Produtos.First();

                context.Remove(dados.First());

                context.SaveChanges();
            }
        }

        public static void DeletarDadocomState(AppDbContext context)
        {
            if (!context.Produtos.Any())
            {
                var dados = from p in context.Produtos
                            where p.Nome.Contains("Lapis")
                            select p;
                //var produto = context.Produtos.First();

                context.Entry(dados.First()).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}

