using Desafio.Seedwork.Domain;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desafio.Domain.MembershipContext.UsuarioAgg
{
    public class Usuario : GuidEntity
    {
        [Required]
        public string Apelido { get; set; }

        [Required]
        public string Senha { get; set; }

        public Status Status { get; set; }
    }
}
