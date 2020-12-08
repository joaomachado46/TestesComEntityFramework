using Microsoft.EntityFrameworkCore.Migrations;

namespace Aulao.Migrations
{
    public partial class PoupularBdd : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome,Preco,Stock) VALUES('Caneta',4.99,10)");
            mb.Sql("INSERT INTO Produtos(Nome,Preco,Stock) VALUES('Lapis',4.99,10)");
            mb.Sql("INSERT INTO Produtos(Nome,Preco,Stock) VALUES('Estojo',4.99,10)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
