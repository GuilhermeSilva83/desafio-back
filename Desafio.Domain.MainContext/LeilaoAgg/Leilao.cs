using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Desafio.Domain.MainContext.UsuarioAgg;
using Desafio.Seedwork.Domain;

namespace Desafio.Domain.MainContext.LeilaoAgg
{
    public class Leilao : Int32Entity
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public decimal ValorInicial { get; set; }

        public bool Usado { get; set; }

        public DateTime DataAbertura { get; set; }


        public DateTime DataFinalizacao { get; set; }


        public int UsuarioResponsavelId { get; set; }

        [ForeignKey(nameof(UsuarioResponsavelId))]
        public Usuario UsuarioResponsavel { get; set; }
    }
}
