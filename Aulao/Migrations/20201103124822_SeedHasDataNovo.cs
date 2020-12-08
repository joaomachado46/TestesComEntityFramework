using Microsoft.EntityFrameworkCore.Migrations;

namespace Aulao.Migrations
{
    public partial class SeedHasDataNovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 60);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Nome", "Preco", "Stock" },
                values: new object[] { 61, "Mochila", 10.99m, 25 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 61);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Nome", "Preco", "Stock" },
                values: new object[] { 60, "Etiquetas", 10.99m, 11 });
        }
    }
}
