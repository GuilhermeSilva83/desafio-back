﻿// <auto-generated />
using System;
using Desafio.Infra.Repositories.MainContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desafio.Infra.Repositories.MainContext.Migrations
{
    [DbContext(typeof(MainUnitOfWork))]
    partial class MainUnitOfWorkModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Desafio.Domain.MainContext.CidadeAgg.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstadoId = 1,
                            Nome = "São Paulo"
                        },
                        new
                        {
                            Id = 2,
                            EstadoId = 1,
                            Nome = "Barueri"
                        },
                        new
                        {
                            Id = 3,
                            EstadoId = 1,
                            Nome = "Osasco"
                        },
                        new
                        {
                            Id = 4,
                            EstadoId = 2,
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 5,
                            EstadoId = 2,
                            Nome = "Cabo Frio"
                        },
                        new
                        {
                            Id = 6,
                            EstadoId = 2,
                            Nome = "Arraial do Cabo"
                        },
                        new
                        {
                            Id = 7,
                            EstadoId = 3,
                            Nome = "Cuiaba"
                        },
                        new
                        {
                            Id = 8,
                            EstadoId = 3,
                            Nome = "Chamada dos Guimaraes"
                        },
                        new
                        {
                            Id = 9,
                            EstadoId = 3,
                            Nome = "Santo Antonio"
                        });
                });

            modelBuilder.Entity("Desafio.Domain.MainContext.EstadoAgg.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "São Paulo"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Mato Grosso"
                        });
                });

            modelBuilder.Entity("Desafio.Domain.MainContext.LeilaoAgg.Leilao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFinalizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Usado")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioResponsavelId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorInicial")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioResponsavelId");

                    b.ToTable("Leilao");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAbertura = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataFinalizacao = new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Grande Leilao de Carros",
                            Usado = true,
                            UsuarioResponsavelId = 1,
                            ValorInicial = 9999.50m
                        },
                        new
                        {
                            Id = 2,
                            DataAbertura = new DateTime(1, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataFinalizacao = new DateTime(1, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Leilao das Casas",
                            Usado = true,
                            UsuarioResponsavelId = 1,
                            ValorInicial = 199999.50m
                        });
                });

            modelBuilder.Entity("Desafio.Domain.MainContext.UsuarioAgg.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Guilherme Silva"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Steve Jobs"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Bill Gates"
                        });
                });

            modelBuilder.Entity("Desafio.Domain.MainContext.CidadeAgg.Cidade", b =>
                {
                    b.HasOne("Desafio.Domain.MainContext.EstadoAgg.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio.Domain.MainContext.LeilaoAgg.Leilao", b =>
                {
                    b.HasOne("Desafio.Domain.MainContext.UsuarioAgg.Usuario", "UsuarioResponsavel")
                        .WithMany()
                        .HasForeignKey("UsuarioResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
