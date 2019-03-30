using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Migrations
{
    public partial class BancoAlterado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<float>(nullable: false),
                    Valortransacao = table.Column<float>(nullable: false),
                    Tipotransacao = table.Column<bool>(nullable: false),
                    Motivo = table.Column<string>(nullable: true),
                    FunIdID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Caixa_Funcionario_FunIdID",
                        column: x => x.FunIdID,
                        principalTable: "Funcionario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Qtde = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RelatorioEstoque",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Qtde = table.Column<float>(nullable: false),
                    Tipo = table.Column<bool>(nullable: false),
                    EstoqueID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioEstoque", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RelatorioEstoque_Estoque_EstoqueID",
                        column: x => x.EstoqueID,
                        principalTable: "Estoque",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_FunIdID",
                table: "Caixa",
                column: "FunIdID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioEstoque_EstoqueID",
                table: "RelatorioEstoque",
                column: "EstoqueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "RelatorioEstoque");

            migrationBuilder.DropTable(
                name: "Estoque");
        }
    }
}
