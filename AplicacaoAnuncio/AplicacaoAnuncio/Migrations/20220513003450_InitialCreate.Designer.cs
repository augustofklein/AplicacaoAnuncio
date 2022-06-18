﻿// <auto-generated />
using System;
using AplicacaoAnuncio.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AplicacaoAnuncio.Migrations
{
    [DbContext(typeof(AnuncioDbContext))]
    [Migration("20220513003450_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Servico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categoria")
                        .HasColumnType("int")
                        .HasColumnName("Categoria");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descricao");

                    b.Property<string>("NomeServico")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NomeServico");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Valor");

                    b.HasKey("Id");

                    b.ToTable("Servicos", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
