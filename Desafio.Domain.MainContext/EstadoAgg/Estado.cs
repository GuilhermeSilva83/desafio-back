using System;
using System.Collections.Generic;
using System.Text;

using Desafio.Domain.MainContext.CidadeAgg;
using Desafio.Seedwork.Domain;

namespace Desafio.Domain.MainContext.EstadoAgg
{
    public class Estado : Int32Entity
    {
        public string Nome { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}
