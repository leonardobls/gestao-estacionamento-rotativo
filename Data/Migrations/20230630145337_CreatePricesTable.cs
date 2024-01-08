using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace gestao_estacionamento_rotativo.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePricesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "VeiculoCategoria");

            migrationBuilder.CreateTable(
                name: "Precos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Time = table.Column<TimeSpan>(type: "interval", nullable: false),
                    CategoriaVeiculoId = table.Column<int>(type: "integer", nullable: false),
                    CateigoriaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Precos_VeiculoCategoria_CateigoriaId",
                        column: x => x.CateigoriaId,
                        principalTable: "VeiculoCategoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Precos_CateigoriaId",
                table: "Precos",
                column: "CateigoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Precos");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "VeiculoCategoria",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
