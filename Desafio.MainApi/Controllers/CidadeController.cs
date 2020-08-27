using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Desafio.Domain.MainContext.CidadeAgg;
using Desafio.Seedwork.Domain;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio.MainApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : Int32CrudController<ICidadeRepository, Cidade>
    {
        public CidadeController(IUnitOfWork uow, ICidadeRepository rep) : base(uow, rep)
        {
        }

        [HttpGet("por-estado/{estadoId:int}")]
        public async Task<IEnumerable<Cidade>> ListarPorEstado(int estadoId)
        {
            return await this.repository.ListarPorEstado(estadoId);
        }

    }
}
