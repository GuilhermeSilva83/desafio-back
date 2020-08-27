using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Desafio.Domain.MainContext.LeilaoAgg;
using Desafio.MainApi.Model;

namespace Desafio.MainApi.Infra
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            //CreateMap<PessoaDto, Pessoa>()
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

        }
    }
}
