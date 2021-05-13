using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoChocolate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chocolates",
                columns: table => new
                {
                    Id_Chocolate = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Porcent_Cacau = table.Column<double>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Data_Validade = table.Column<DateTime>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Porcent_Desconto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chocolates", x => x.Id_Chocolate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chocolates");
        }
    }
}
