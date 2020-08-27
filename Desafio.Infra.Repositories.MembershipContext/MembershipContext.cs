using Desafio.Domain.MembershipContext.UsuarioAgg;
using Desafio.Seedwork.Domain;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Infra.Repositories.MembershipContext
{
    public class MembershipContext : DbContext, IUnitOfWork
    {
        public readonly Guid Guid = Guid.NewGuid();
        public DbSet<Usuario> Usuario { get; set; }

        public void Commit()
        {
            this.SaveChanges();
        }

        public MembershipContext(DbContextOptions<MembershipContext> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
            new Usuario()
            {
                Id = Guid.NewGuid(),
                Apelido = "admin",
                Senha = "abc123"
            });
        }
    }
}
