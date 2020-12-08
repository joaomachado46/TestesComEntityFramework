using Microsoft.EntityFrameworkCore.Migrations;

namespace Aulao.Migrations
{
    public partial class SeedProdutosHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Nome", "Preco", "Stock" },
                values: new object[] { 10, "Etiquetas", 10.99m, 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 10);
        }
    }
}
