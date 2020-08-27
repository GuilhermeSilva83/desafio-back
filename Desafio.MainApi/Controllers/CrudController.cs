using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Desafio.Seedwork.Domain;
using System.Threading;

namespace Desafio.MainApi.Controllers
{
    public class Int32CrudController<TRepository, TEntity> : ControllerBase
        where TRepository : class, IRepository<TEntity, int>
        where TEntity : class

    {
        protected IMapper mapper;
        protected IUnitOfWork unitOfWork = null;
        protected TRepository repository = null;

        public Int32CrudController(IUnitOfWork uow, TRepository rep)
        {
            this.unitOfWork = uow;
            this.repository = rep;
        }

        public Int32CrudController(IUnitOfWork uow, TRepository rep, IMapper mapper)
        {
            this.mapper = mapper;
            this.unitOfWork = uow;
            this.repository = rep;
        }


        [HttpGet]
        public virtual async Task<IEnumerable<TEntity>> List()
        {
            return await repository.List();
        }


        [HttpGet("{id}")]
        public virtual async Task<TEntity> Get(int id)
        {
            return await this.repository.GetById(id);
        }

        [HttpPost]
        [HttpPut("{id}")]
        public virtual OperationResult Save([FromBody] TEntity value, int id)
        {
            repository.Save(value);
            unitOfWork.Commit();
            return OperationResult.Ok(value);
        }

        [HttpDelete("{id}")]
        public virtual OperationResult Delete(int id)
        {
            repository.DeleteById(id);
            unitOfWork.Commit();
            return OperationResult.Ok();
        }
    }
}
