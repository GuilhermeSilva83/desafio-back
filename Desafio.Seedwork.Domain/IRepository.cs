using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Desafio.Seedwork.Domain
{
    public interface IRepository<TEntity, TId>
        where TEntity : class
    {
        void Save(TEntity entity);

        Task<List<TEntity>> List();

        void DeleteById(TId id);
        Task<TEntity> GetById(TId id);
    }
}
