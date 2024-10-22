﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Thunders_Repositories.DataContext;

#nullable disable

namespace Thunders_Repositories.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241022011852_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Thunders_Borders.Entities.ToDoList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tarefa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Vencimento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tarefas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"),
                            Criacao = new DateTime(2024, 10, 21, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8726),
                            Descricao = "Teste 1",
                            Observacoes = "Teste observação 1",
                            Prioridade = 0,
                            Responsavel = "Queres",
                            Status = 0,
                            Tarefa = "Teste 1",
                            Vencimento = new DateTime(2024, 11, 20, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8728)
                        },
                        new
                        {
                            Id = new Guid("b66910d4-f789-473d-b997-16efabdcb5d3"),
                            Criacao = new DateTime(2024, 10, 21, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8734),
                            Descricao = "Teste 2",
                            Observacoes = "Teste observação 2",
                            Prioridade = 1,
                            Responsavel = "Thunders",
                            Status = 2,
                            Tarefa = "Teste 2",
                            Vencimento = new DateTime(2024, 11, 5, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8735)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}