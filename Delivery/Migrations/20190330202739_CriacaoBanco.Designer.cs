﻿// <auto-generated />
using System;
using Delivery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Delivery.Migrations
{
    [DbContext(typeof(DeliveryContext))]
    [Migration("20190330202739_CriacaoBanco")]
    partial class CriacaoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Delivery.Models.Checkinout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Checkin");

                    b.Property<DateTime>("Cheout");

                    b.Property<int?>("FuncionarioID");

                    b.HasKey("ID");

                    b.HasIndex("FuncionarioID");

                    b.ToTable("Checkinout");
                });

            modelBuilder.Entity("Delivery.Models.Extra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<float>("Preco");

                    b.HasKey("ID");

                    b.ToTable("Extra");
                });

            modelBuilder.Entity("Delivery.Models.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contato");

                    b.Property<string>("Funcao");

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Delivery.Models.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Desconto");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<float>("Preco");

                    b.Property<string>("Tamanho");

                    b.HasKey("ID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Delivery.Models.ProdutoExtra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExtIdID");

                    b.Property<float>("Preco_ext");

                    b.Property<float>("Preco_pro");

                    b.Property<int?>("ProIdID");

                    b.Property<int>("Qtde_ext");

                    b.Property<int>("Qtde_pro");

                    b.Property<int?>("VendasID");

                    b.HasKey("ID");

                    b.HasIndex("ExtIdID");

                    b.HasIndex("ProIdID");

                    b.HasIndex("VendasID");

                    b.ToTable("ProdutoExtra");
                });

            modelBuilder.Entity("Delivery.Models.Vendas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Complemento");

                    b.Property<DateTime>("Datahora");

                    b.Property<float>("Desconto");

                    b.Property<int?>("FuncionarioID");

                    b.Property<string>("Metodopagamento");

                    b.Property<string>("Numero");

                    b.Property<string>("Rua");

                    b.Property<float>("Total");

                    b.HasKey("ID");

                    b.HasIndex("FuncionarioID");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Delivery.Models.Checkinout", b =>
                {
                    b.HasOne("Delivery.Models.Funcionario")
                        .WithMany("Checkinouts")
                        .HasForeignKey("FuncionarioID");
                });

            modelBuilder.Entity("Delivery.Models.ProdutoExtra", b =>
                {
                    b.HasOne("Delivery.Models.Extra", "ExtId")
                        .WithMany()
                        .HasForeignKey("ExtIdID");

                    b.HasOne("Delivery.Models.Produto", "ProId")
                        .WithMany()
                        .HasForeignKey("ProIdID");

                    b.HasOne("Delivery.Models.Vendas")
                        .WithMany("Produtosextras")
                        .HasForeignKey("VendasID");
                });

            modelBuilder.Entity("Delivery.Models.Vendas", b =>
                {
                    b.HasOne("Delivery.Models.Funcionario")
                        .WithMany("Vendidos")
                        .HasForeignKey("FuncionarioID");
                });
#pragma warning restore 612, 618
        }
    }
}