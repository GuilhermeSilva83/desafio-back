using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Desafio.Domain.MainContext.EstadoAgg;
using Desafio.Seedwork.Domain;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio.MainApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : Int32CrudController<IEstadoRepository, Estado>
    {
        public EstadoController(IUnitOfWork uow, IEstadoRepository rep) : base(uow, rep)
        {
        }
    }
}
