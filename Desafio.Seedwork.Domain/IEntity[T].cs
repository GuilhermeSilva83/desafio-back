using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Desafio.Seedwork.Domain
{
    public interface IEntity<TId> : IEntity
    {
        TId Id { get; set; }
    }
}
