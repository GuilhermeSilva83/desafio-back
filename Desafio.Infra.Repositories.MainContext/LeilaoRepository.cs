using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Desafio.Domain.MainContext.LeilaoAgg;
using Desafio.Seedwork.Domain;
using Desafio.Infra.Repositories.Seedwork;

namespace Desafio.Infra.Repositories.MainContext
{
    public class LeilaoRepository : Int32Repository<Leilao, MainUnitOfWork>, ILeilaoRepository
    {
        public LeilaoRepository(IUnitOfWork u) : base(u as MainUnitOfWork)
        {

        }

        public override async Task<Leilao> GetById(int id)
        {
            return await GetSet()
                    .FirstOrDefaultAsync(w => w.Id == id);
        }


        public override async Task<List<Leilao>> List()
        {
            return await GetSet()
                            .Include(w => w.UsuarioResponsavel)
                            .ToListAsync();
        }
    }
}
