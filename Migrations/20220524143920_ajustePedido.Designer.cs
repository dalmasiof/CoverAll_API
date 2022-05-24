﻿// <auto-generated />
using System;
using CoverAll_API.C_DAL.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoverAll_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220524143920_ajustePedido")]
    partial class ajustePedido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("CoverAll_API.C_DAL.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.Property<string>("UF")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CEP = "05668545",
                            CPF = "44764959666",
                            Cidade = "São Paulo",
                            DataNascimento = new DateTime(1978, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Endereco = "Rua Pio XII",
                            Genero = "Masculino",
                            Nome = "Eduardo",
                            Sobrenome = "Noah Ramos",
                            Telefone = "88 3889-3701",
                            UF = "CE",
                            email = "eduardo_noah_ramos@trimempresas.com.br"
                        });
                });

            modelBuilder.Entity("CoverAll_API.C_DAL.Model.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdCLiente")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.Property<string>("Usuario")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Logins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdCLiente = 1,
                            Senha = "admin",
                            Usuario = "admin"
                        });
                });

            modelBuilder.Entity("CoverAll_API.C_DAL.Model.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Frete")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdProdutoCliente")
                        .HasColumnType("int");

                    b.Property<string>("StatusEntrega")
                        .HasColumnType("longtext");

                    b.Property<string>("StatusPagamento")
                        .HasColumnType("longtext");

                    b.Property<string>("StatusPedido")
                        .HasColumnType("longtext");

                    b.Property<string>("Tamanho")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalAPagar")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("CoverAll_API.C_DAL.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Tamanho")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlImg")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cor = "Vermelho",
                            Descricao = "Camiseta vermelha",
                            Genero = "M",
                            Observacao = "Camiseta lisa vermelha",
                            Preco = 45.00m,
                            UrlImg = "prod-1.webp"
                        },
                        new
                        {
                            Id = 2,
                            Cor = "Azul",
                            Descricao = "Camiseta Azul",
                            Genero = "M",
                            Observacao = "Camiseta lisa azul",
                            Preco = 45.00m,
                            UrlImg = "prod-2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Cor = "Preto",
                            Descricao = "Camiseta Preta",
                            Genero = "M",
                            Observacao = "Camiseta lisa preta",
                            Preco = 55.00m,
                            UrlImg = "prod-3.webp"
                        },
                        new
                        {
                            Id = 4,
                            Cor = "Branco",
                            Descricao = "Camiseta Branca",
                            Genero = "M",
                            Observacao = "Camiseta lisa branca",
                            Preco = 55.00m,
                            UrlImg = "prod-4.webp"
                        },
                        new
                        {
                            Id = 5,
                            Cor = "Preta",
                            Descricao = "Camiseta Preta Star wars",
                            Genero = "M",
                            Observacao = "Camiseta stampada star wars",
                            Preco = 60.00m,
                            UrlImg = "prod-5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Cor = "Preto",
                            Descricao = "Camiseta Preta Naruto",
                            Genero = "M",
                            Observacao = "Camiseta stampada Naruto",
                            Preco = 55.00m,
                            UrlImg = "prod-6.webp"
                        },
                        new
                        {
                            Id = 7,
                            Cor = "Vermelho",
                            Descricao = "Camiseta vermelha",
                            Genero = "F",
                            Observacao = "Camiseta lisa vermelha",
                            Preco = 45.00m,
                            UrlImg = "prod-7.webp"
                        },
                        new
                        {
                            Id = 8,
                            Cor = "Azul",
                            Descricao = "Camiseta Azul",
                            Genero = "F",
                            Observacao = "Camiseta lisa azul",
                            Preco = 45.00m,
                            UrlImg = "prod-8.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Cor = "Preto",
                            Descricao = "Camiseta Preta",
                            Genero = "F",
                            Observacao = "Camiseta lisa preta",
                            Preco = 55.00m,
                            UrlImg = "prod-9.webp"
                        },
                        new
                        {
                            Id = 10,
                            Cor = "Branco",
                            Descricao = "Camiseta Branca",
                            Genero = "F",
                            Observacao = "Camiseta lisa branca",
                            Preco = 55.00m,
                            UrlImg = "prod-10.webp"
                        },
                        new
                        {
                            Id = 11,
                            Cor = "Preta",
                            Descricao = "Camiseta Preta Star wars",
                            Genero = "F",
                            Observacao = "Camiseta stampada star wars",
                            Preco = 60.00m,
                            UrlImg = "prod-11.webp"
                        },
                        new
                        {
                            Id = 12,
                            Cor = "Preto",
                            Descricao = "Camiseta Preta Naruto",
                            Genero = "F",
                            Observacao = "Camiseta stampada Naruto",
                            Preco = 55.00m,
                            UrlImg = "prod-12.webp"
                        },
                        new
                        {
                            Id = 13,
                            Cor = "Jeans",
                            Descricao = "Calça jeans",
                            Genero = "M",
                            Observacao = "Calça jeans",
                            Preco = 100.00m,
                            UrlImg = "prod-13.webp"
                        },
                        new
                        {
                            Id = 14,
                            Cor = "Bege",
                            Descricao = "Calça jogger",
                            Genero = "M",
                            Observacao = "Calça jogger bege",
                            Preco = 125.00m,
                            UrlImg = "prod-14.jfif"
                        },
                        new
                        {
                            Id = 15,
                            Cor = "Preto",
                            Descricao = "Calça preta sarja",
                            Genero = "M",
                            Observacao = "Calça preta de sarja",
                            Preco = 110.00m,
                            UrlImg = "prod-15.jfif"
                        },
                        new
                        {
                            Id = 16,
                            Cor = "Cinza",
                            Descricao = "Bermuda cinza",
                            Genero = "M",
                            Observacao = "Bermuda cinza",
                            Preco = 65.00m,
                            UrlImg = "prod-16.webp"
                        },
                        new
                        {
                            Id = 17,
                            Cor = "Jeans",
                            Descricao = "Calça jeans",
                            Genero = "F",
                            Observacao = "Calça jeans",
                            Preco = 100.00m,
                            UrlImg = "prod-17.jpg"
                        },
                        new
                        {
                            Id = 18,
                            Cor = "Bege",
                            Descricao = "Calça jogger",
                            Genero = "F",
                            Observacao = "Calça jogger bege",
                            Preco = 125.00m,
                            UrlImg = "prod-18.webp"
                        },
                        new
                        {
                            Id = 19,
                            Cor = "Preto",
                            Descricao = "Calça preta sarja",
                            Genero = "F",
                            Observacao = "Calça preta de sarja",
                            Preco = 110.00m,
                            UrlImg = "prod-19.webp"
                        },
                        new
                        {
                            Id = 20,
                            Cor = "Preto",
                            Descricao = "Vestido Preto",
                            Genero = "F",
                            Observacao = "Vestido preto",
                            Preco = 65.00m,
                            UrlImg = "prod-20.webp"
                        });
                });

            modelBuilder.Entity("PedidoProduto", b =>
                {
                    b.Property<int>("PedidosId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("PedidosId", "ProdutosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("PedidoProduto");
                });

            modelBuilder.Entity("PedidoProduto", b =>
                {
                    b.HasOne("CoverAll_API.C_DAL.Model.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoverAll_API.C_DAL.Model.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
