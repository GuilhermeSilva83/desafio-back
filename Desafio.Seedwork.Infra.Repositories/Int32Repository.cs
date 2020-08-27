using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Desafio.Seedwork.Domain;

namespace Desafio.Infra.Repositories.Seedwork
{
    public class Int32Repository<TEntity, TUnitOfWork> : BaseRepository<TEntity, int, TUnitOfWork>
       where TEntity : class, IEntity<int>, new()
       where TUnitOfWork : DbContext, IUnitOfWork
    {
        public Int32Repository(TUnitOfWork ct) : base(ct)
        {
        }

        public override async Task<TEntity> GetById(int id)
        {
            return await GetSet().FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
