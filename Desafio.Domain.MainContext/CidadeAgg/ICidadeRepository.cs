using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Desafio.Seedwork.Domain;

namespace Desafio.Domain.MainContext.CidadeAgg
{
    public interface ICidadeRepository : IRepository<Cidade, int>
    {
        Task<List<Cidade>> ListarPorEstado(int estadoId);
    }
}
