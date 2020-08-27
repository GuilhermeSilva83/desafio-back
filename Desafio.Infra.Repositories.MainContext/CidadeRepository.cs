using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Desafio.Domain.MainContext.CidadeAgg;
using Desafio.Domain.MainContext.EstadoAgg;
using Desafio.Domain.MainContext.LeilaoAgg;
using Desafio.Seedwork.Domain;
using Desafio.Infra.Repositories.Seedwork;

namespace Desafio.Infra.Repositories.MainContext
{
    public class CidadeRepository : Int32Repository<Cidade, MainUnitOfWork>, ICidadeRepository
    {
        public CidadeRepository(IUnitOfWork u) : base(u as MainUnitOfWork)
        {

        }

        public async Task<List<Cidade>> ListarPorEstado(int estadoId)
        {
            return await GetSet().Where(w => w.EstadoId == estadoId).ToListAsync();
        }
    }
}
