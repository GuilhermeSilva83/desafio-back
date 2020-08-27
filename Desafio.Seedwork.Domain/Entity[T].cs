using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Desafio.Seedwork.Domain
{
    public abstract class Entity<TId> : IEntity<TId>
    {
        public abstract TId Id { get; set; }
        public abstract bool IsTransient();
    }
}
