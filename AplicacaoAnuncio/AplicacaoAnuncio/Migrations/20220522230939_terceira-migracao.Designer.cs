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
    [Migration("20220522230939_terceira-migracao")]
    partial class terceiramigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Avaliacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Nota")
                        .HasColumnType("int")
                        .HasColumnName("Nota");

                    b.Property<Guid>("ServicoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ServicoId");

                    b.ToTable("Avaliacoes", "dbo");
                });

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Bairro");

                    b.Property<string>("Cep")
                        .HasColumnType("char(9)")
                        .HasColumnName("Cep");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Cidade");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Estado")
                        .HasColumnType("char(2)")
                        .HasColumnName("Estado");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Logradouro");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("Numero");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Enderecos", "dbo");
                });

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

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Valor");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Servicos", "dbo");
                });

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(18)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("char(10)")
                        .HasColumnName("DataNascimento");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .HasColumnName("Sexo");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", "dbo");
                });

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Avaliacao", b =>
                {
                    b.HasOne("AplicacaoAnuncio.Dominio.Servico", null)
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Endereco", b =>
                {
                    b.HasOne("AplicacaoAnuncio.Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplicacaoAnuncio.Dominio.Servico", b =>
                {
                    b.HasOne("AplicacaoAnuncio.Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
