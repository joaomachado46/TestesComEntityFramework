using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Aulao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acessar inserir e imprimir dados na tela
            using (var dbContext = new AppDbContext())
            {
                ///Metodos para rastrear o estado das entidades/dados inseridos
                ///VER METODO/CLASS ChangeTraker
                ChangeTracker.ChangeTrackerMetodos(dbContext);


                ///Teste com 3 transações e um unico SaveChanges()
                ///INSERIR DADOS NA BD:
                if (!dbContext.Produtos.Any())
                {
                    var produto = new Produto();
                    produto.Nome = "Lapis";
                    produto.Preco = 10.99M;
                    produto.Stock = 200;

                    dbContext.Produtos.Add(produto);

                    ///MODIFICAR DADOS NA BD:
                    var meuProduto = dbContext.Produtos.Find(134);
                    meuProduto.Nome = "Mochila nova";

                    ///REMOVER PRODUTO DA BD:
                    var ultimoProduto = dbContext.Produtos.ToList().Last();
                    dbContext.Produtos.Remove(ultimoProduto);

                    try
                    {
                        int resultadosAlterados = dbContext.SaveChanges();
                        Console.WriteLine(resultadosAlterados + " registos alterados");
                    }
                    catch (DbUpdateException e)
                    {
                        Console.WriteLine("Erro ao efetuar as alterações " + e.Message);
                    }
                }

                ///Usando a class PopularBDcomCode() para popular BD, chamo o metodo da class e dou com
                ///como parametro o novo obj instanciaso DbContext. ou posso definir um construtor na
                ///classProduto e dar como parametro.
                ///VER METODO/CLASS
                PopularBDcomCode.SeedData(dbContext);


                ///Aqui é uma outra forma de popular a BD, usando uma nova instancia da class Produto
                ///e passar ela como parametro para a instancia criada anteriormente de Context
                ///VER METODO/CLASS
                PoupularBDcomDbContext.PopularBdcomDbContext(dbContext);
                ///aqui é a opçao com LIST da mesma class/metodo
                ///VER METODO/CLASS
                PoupularBDcomDbContext.PopularBdcomDbContextLIST(dbContext);


                ///Esta é uma opção para deletar dados de uma Bd com DbSet
                ///neste caso estou a eliminar o 1º resultado da lista
                ///VER METODO/CLASS

                DeleteDadosBD.DeletarDadocomDbSet(dbContext);
                ///outra opçao é com State como mostra na mesma class/metodo
                ///VER METODO/CLASS

                DeleteDadosBD.DeletarDadocomState(dbContext);

                ///Com esta opçao vamos tar a procurar o item que queremos alterar pelo nome, mas 
                ///também podemos definir a busca por Id.
                ///VER METODO/CLASS

                ActualizarDadosDb.UpdateBd(dbContext);

                //listar a base de dados(metodo)
                ImprimirDataBase.ExibirDadosDaBaseDados(dbContext);
            }
            Console.ReadKey();
        }
        
        /// <summary>
        ///Metodo para exibir o estado das entidades. 
        
       
    }
}
