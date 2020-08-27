using Desafio.Domain.MembershipContext.UsuarioAgg;
using Desafio.Infra.Repositories.Seedwork;
using Desafio.Seedwork.Domain;

using Microsoft.EntityFrameworkCore.Internal;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio.Infra.Repositories.MembershipContext
{
    public class UsuarioRepository : GuidRepository<Usuario, MembershipContext>, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork ct) : base(ct as MembershipContext)
        {

        }

        public Usuario Get(string apelido, string senha)
        {

            return this.GetSet()
                .FirstOrDefault(w =>
                    w.Apelido.ToLower() == apelido.ToLower() &&
                    w.Senha == senha);
        }
    }
}
