using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Desafio.Domain.MainContext.CidadeAgg;

namespace Desafio.MainApi.Model
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Cep { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CidadeId { get; set; }

        public CidadeDto Cidade { get; set; }

        public int EstadoId { get; set; }

    }
}
