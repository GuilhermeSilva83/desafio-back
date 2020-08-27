using Desafio.Domain.MainContext.UsuarioAgg;
using Desafio.Infra.Repositories.Seedwork;
using Desafio.Seedwork.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Infra.Repositories.MainContext
{
    public class UsuarioRepository : Int32Repository<Usuario, MainUnitOfWork>, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork u) : base(u as MainUnitOfWork)
        {

        }
    }
}
