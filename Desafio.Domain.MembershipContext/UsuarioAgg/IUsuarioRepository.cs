using Desafio.Seedwork.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Domain.MembershipContext.UsuarioAgg
{
    public interface IUsuarioRepository : IGuidRepository<Usuario>
    {
        Usuario Get(string apelido, string senha);
    }
}
