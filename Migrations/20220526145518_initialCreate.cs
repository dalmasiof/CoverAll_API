using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoverAll_API.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sobrenome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCLiente = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Frete = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalAPagar = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StatusPedido = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StatusPagamento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StatusEntrega = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tamanho = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EnderecoEntrega = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Cor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tamanho = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrlImg = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PedidoProduto",
                columns: table => new
                {
                    PedidosId = table.Column<int>(type: "int", nullable: false),
                    ProdutosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProduto", x => new { x.PedidosId, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Pedidos_PedidosId",
                        column: x => x.PedidosId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CEP", "CPF", "Cidade", "DataNascimento", "Endereco", "Genero", "Nome", "Sobrenome", "Telefone", "UF", "email" },
                values: new object[] { 1, "05668545", "44764959666", "São Paulo", new DateTime(1978, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Pio XII", "Masculino", "Eduardo", "Noah Ramos", "88 3889-3701", "CE", "eduardo_noah_ramos@trimempresas.com.br" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "IdCLiente", "Senha", "Usuario" },
                values: new object[] { 1, 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Cor", "Descricao", "Genero", "Observacao", "Preco", "Tamanho", "UrlImg" },
                values: new object[,]
                {
                    { 18, "Bege", "Calça jogger", "F", "Calça jogger bege", 125.00m, null, "prod-18.webp" },
                    { 17, "Jeans", "Calça jeans", "F", "Calça jeans", 100.00m, null, "prod-17.jpg" },
                    { 16, "Cinza", "Bermuda cinza", "M", "Bermuda cinza", 65.00m, null, "prod-16.webp" },
                    { 15, "Preto", "Calça preta sarja", "M", "Calça preta de sarja", 110.00m, null, "prod-15.jfif" },
                    { 14, "Bege", "Calça jogger", "M", "Calça jogger bege", 125.00m, null, "prod-14.jfif" },
                    { 13, "Jeans", "Calça jeans", "M", "Calça jeans", 100.00m, null, "prod-13.webp" },
                    { 12, "Preto", "Camiseta Preta Naruto", "F", "Camiseta stampada Naruto", 55.00m, null, "prod-12.webp" },
                    { 11, "Preta", "Camiseta Preta Star wars", "F", "Camiseta stampada star wars", 60.00m, null, "prod-11.webp" },
                    { 10, "Branco", "Camiseta Branca", "F", "Camiseta lisa branca", 55.00m, null, "prod-10.webp" },
                    { 9, "Preto", "Camiseta Preta", "F", "Camiseta lisa preta", 55.00m, null, "prod-9.webp" },
                    { 8, "Azul", "Camiseta Azul", "F", "Camiseta lisa azul", 45.00m, null, "prod-8.jpg" },
                    { 7, "Vermelho", "Camiseta vermelha", "F", "Camiseta lisa vermelha", 45.00m, null, "prod-7.webp" },
                    { 6, "Preto", "Camiseta Preta Naruto", "M", "Camiseta stampada Naruto", 55.00m, null, "prod-6.webp" },
                    { 5, "Preta", "Camiseta Preta Star wars", "M", "Camiseta stampada star wars", 60.00m, null, "prod-5.jpg" },
                    { 4, "Branco", "Camiseta Branca", "M", "Camiseta lisa branca", 55.00m, null, "prod-4.webp" },
                    { 3, "Preto", "Camiseta Preta", "M", "Camiseta lisa preta", 55.00m, null, "prod-3.webp" },
                    { 2, "Azul", "Camiseta Azul", "M", "Camiseta lisa azul", 45.00m, null, "prod-2.jpg" },
                    { 1, "Vermelho", "Camiseta vermelha", "M", "Camiseta lisa vermelha", 45.00m, null, "prod-1.webp" },
                    { 19, "Preto", "Calça preta sarja", "F", "Calça preta de sarja", 110.00m, null, "prod-19.webp" },
                    { 20, "Preto", "Vestido Preto", "F", "Vestido preto", 65.00m, null, "prod-20.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_ProdutosId",
                table: "PedidoProduto",
                column: "ProdutosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "PedidoProduto");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
