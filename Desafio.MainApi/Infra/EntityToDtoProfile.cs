using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Desafio.Domain.MainContext.CidadeAgg;
using Desafio.Domain.MainContext.EstadoAgg;
using Desafio.Domain.MainContext.LeilaoAgg;
using Desafio.MainApi.Model;

namespace Desafio.MainApi.Infra
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            //CreateMap<Pessoa, PessoaDto>()
            //    .ForMember(dest =>
            //        dest.EstadoId,
            //        opt => opt.MapFrom(src => src.Cidade.EstadoId))
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    ;

            CreateMap<Cidade, CidadeDto>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<Estado, EstadoDto>().IgnoreAllPropertiesWithAnInaccessibleSetter();

        }
    }
}
