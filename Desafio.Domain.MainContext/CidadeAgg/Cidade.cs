using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Desafio.Domain.MainContext.EstadoAgg;
using Desafio.Seedwork.Domain;

namespace Desafio.Domain.MainContext.CidadeAgg
{
    public class Cidade : Int32Entity
    {
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        [ForeignKey(nameof(EstadoId))]
        public Estado Estado { get; set; }
    }
}
