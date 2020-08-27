using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Seedwork.Domain
{
    public interface IGuidRepository<TEntity> : IRepository<TEntity, Guid>
        where TEntity : class
    {

    }
}
