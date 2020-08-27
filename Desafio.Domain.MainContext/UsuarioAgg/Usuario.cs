using Desafio.Seedwork.Domain;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desafio.Domain.MainContext.UsuarioAgg
{
    public class Usuario : Int32Entity
    {
        [Required]
        public string Nome { get; set; }
    }
}
