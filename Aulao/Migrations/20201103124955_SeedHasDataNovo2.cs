using Microsoft.EntityFrameworkCore.Migrations;

namespace Aulao.Migrations
{
    public partial class SeedHasDataNovo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Nome", "Preco", "Stock" },
                values: new object[] { 60, "MochilaNova", 10.99m, 25 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 60);
        }
    }
}
