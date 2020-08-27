using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Desafio.Seedwork.Domain;

namespace Desafio.Infra.Repositories.Seedwork
{
    public abstract class BaseRepository<TEntity, TId, TUnitOfWork> : IRepository<TEntity, TId>
       where TEntity : class, IEntity<TId>, new()
       where TUnitOfWork : DbContext, IUnitOfWork
    {
        protected readonly TUnitOfWork ct;
        public BaseRepository(TUnitOfWork ct)
        {
            this.ct = ct;
        }

        public virtual void DeleteById(TId id)
        {
            var set = GetSet();
            //  var e = await set.AsNoTracking().FirstOrDefaultAsync(w => w.Id == id); // await this.GetById(id);
            var e = new TEntity();
            e.Id = id;
            set.Remove(e);
        }

        public virtual void Save(TEntity entity)
        {
            if (entity.IsTransient())
            {
                GetSet().Add(entity);
            }
            else
            {
                //GetSet().Attach(entity);
                GetSet().Update(entity);

            }
        }

        public abstract Task<TEntity> GetById(TId id);

        public virtual async Task<List<TEntity>> List()
        {
            return await GetSet().ToListAsync();
        }

        protected virtual DbSet<TEntity> GetSet()
        {
            return ct.Set<TEntity>();
        }
    }
}
