using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Desafio.Domain.MainContext.LeilaoAgg;
using Desafio.Seedwork.Domain;
using Desafio.MainApi.Model;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio.MainApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeilaoController : Int32CrudController<ILeilaoRepository, Leilao>
    {
        public LeilaoController(IUnitOfWork uow, ILeilaoRepository rep, IMapper mapper) : base(uow, rep, mapper)
        {
        }
    }
}
