using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Seedwork.Domain
{
    public interface IInt32Repository<TEntity> : IRepository<TEntity, int>
        where TEntity : class
    {

    }
}
