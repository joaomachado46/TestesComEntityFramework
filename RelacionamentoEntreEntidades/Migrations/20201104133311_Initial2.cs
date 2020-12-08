﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RelacionamentoEntreEntidades.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Livros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutorId",
                table: "Livros",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "AutorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_AutorId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Livros");
        }
    }
}
