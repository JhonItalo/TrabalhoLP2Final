using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Migrations
{
    public partial class CriacaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Extra",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Preco = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Funcao = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Preco = table.Column<float>(nullable: false),
                    Tamanho = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Desconto = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Checkinout",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Checkin = table.Column<DateTime>(nullable: false),
                    Cheout = table.Column<DateTime>(nullable: false),
                    FuncionarioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkinout", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Checkinout_Funcionario_FuncionarioID",
                        column: x => x.FuncionarioID,
                        principalTable: "Funcionario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Total = table.Column<float>(nullable: false),
                    Metodopagamento = table.Column<string>(nullable: true),
                    Desconto = table.Column<float>(nullable: false),
                    Rua = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Datahora = table.Column<DateTime>(nullable: false),
                    FuncionarioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vendas_Funcionario_FuncionarioID",
                        column: x => x.FuncionarioID,
                        principalTable: "Funcionario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoExtra",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Qtde_pro = table.Column<int>(nullable: false),
                    Qtde_ext = table.Column<int>(nullable: false),
                    Preco_pro = table.Column<float>(nullable: false),
                    Preco_ext = table.Column<float>(nullable: false),
                    ProIdID = table.Column<int>(nullable: true),
                    ExtIdID = table.Column<int>(nullable: true),
                    VendasID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoExtra", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProdutoExtra_Extra_ExtIdID",
                        column: x => x.ExtIdID,
                        principalTable: "Extra",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoExtra_Produto_ProIdID",
                        column: x => x.ProIdID,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoExtra_Vendas_VendasID",
                        column: x => x.VendasID,
                        principalTable: "Vendas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkinout_FuncionarioID",
                table: "Checkinout",
                column: "FuncionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoExtra_ExtIdID",
                table: "ProdutoExtra",
                column: "ExtIdID");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoExtra_ProIdID",
                table: "ProdutoExtra",
                column: "ProIdID");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoExtra_VendasID",
                table: "ProdutoExtra",
                column: "VendasID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_FuncionarioID",
                table: "Vendas",
                column: "FuncionarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkinout");

            migrationBuilder.DropTable(
                name: "ProdutoExtra");

            migrationBuilder.DropTable(
                name: "Extra");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
