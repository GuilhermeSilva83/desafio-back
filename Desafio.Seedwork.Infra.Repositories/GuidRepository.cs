using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Desafio.Seedwork.Domain;

namespace Desafio.Infra.Repositories.Seedwork
{
    public class GuidRepository<TEntity, TUnitOfWork> : BaseRepository<TEntity, Guid, TUnitOfWork>, IGuidRepository<TEntity>
       where TEntity : class, IEntity<Guid>, new()
       where TUnitOfWork : DbContext, IUnitOfWork
    {
        public GuidRepository(TUnitOfWork ct) : base(ct)
        {

        }

        public override async Task<TEntity> GetById(Guid id)
        {
            return await GetSet().FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
