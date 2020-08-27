using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

using Desafio.Domain.MainContext.LeilaoAgg;
using Desafio.Seedwork.Domain;
using Desafio.Domain.MainContext.CidadeAgg;
using Desafio.Domain.MainContext.EstadoAgg;
using System.Linq;
using Desafio.Domain.MainContext.UsuarioAgg;

namespace Desafio.Infra.Repositories.MainContext
{
    public class MainUnitOfWork : DbContext, IUnitOfWork
    {
        public DbSet<Leilao> Leilao { get; set; }
        public DbSet<Cidade> Cidade { get; set; }


        public DbSet<Estado> Estado { get; set; }

        public void Commit()
        {
            this.SaveChanges();
        }



        public MainUnitOfWork(DbContextOptions<MainUnitOfWork> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Leilao>()
                .Property(p => p.ValorInicial)
                .HasColumnType("decimal(18,4)");



            modelBuilder.Entity<Leilao>().HasData(
                new Leilao()
                {
                    Id = 1,
                    DataAbertura = new DateTime(),
                    DataFinalizacao = new DateTime().AddDays(10),
                    Nome = "Grande Leilao de Carros",
                    Usado = true,
                    UsuarioResponsavelId = 1,
                    ValorInicial = 9999.50m
                },
                new Leilao()
                {
                    Id = 2,
                    DataAbertura = new DateTime().AddDays(1),
                    DataFinalizacao = new DateTime().AddDays(5),
                    Nome = "Leilao das Casas",
                    Usado = true,
                    UsuarioResponsavelId = 1,
                    ValorInicial = 199999.50m
                });

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { Id = 1, Nome = "Guilherme Silva" },
                new Usuario() { Id = 2, Nome = "Steve Jobs" },
                new Usuario() { Id = 3, Nome = "Bill Gates" }
                );

            modelBuilder.Entity<Estado>().HasData(
                new Estado()
                {
                    Id = 1,
                    Nome = "São Paulo",
                },
                new Estado()
                {
                    Id = 2,
                    Nome = "Rio de Janeiro",
                },
                new Estado()
                {
                    Id = 3,
                    Nome = "Mato Grosso",
                });

            modelBuilder.Entity<Cidade>().HasData(
                  new Cidade() { Id = 1, EstadoId = 1, Nome = "São Paulo" },
                  new Cidade() { Id = 2, EstadoId = 1, Nome = "Barueri" },
                  new Cidade() { Id = 3, EstadoId = 1, Nome = "Osasco" },
                  new Cidade() { Id = 4, EstadoId = 2, Nome = "Rio de Janeiro" },
                  new Cidade() { Id = 5, EstadoId = 2, Nome = "Cabo Frio" },
                  new Cidade() { Id = 6, EstadoId = 2, Nome = "Arraial do Cabo" },
                  new Cidade() { Id = 7, EstadoId = 3, Nome = "Cuiaba" },
                  new Cidade() { Id = 8, EstadoId = 3, Nome = "Chamada dos Guimaraes" },
                  new Cidade() { Id = 9, EstadoId = 3, Nome = "Santo Antonio" }
                );
        }
    }
}
