using System;
using System.Collections.Generic;
using System.Text;

using Desafio.Domain.MainContext.EstadoAgg;
using Desafio.Infra.Repositories.Seedwork;
using Desafio.Seedwork.Domain;

namespace Desafio.Infra.Repositories.MainContext
{
    public class EstadoRepository : Int32Repository<Estado, MainUnitOfWork>, IEstadoRepository
    {
        public EstadoRepository(IUnitOfWork u) : base(u as MainUnitOfWork)
        {

        }
    }
}
