using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Desafio.Domain.MainContext.UsuarioAgg;
using Desafio.Infra.Repositories.MainContext;
using Desafio.Seedwork.Domain;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.MainApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Int32CrudController<IUsuarioRepository, Usuario>
    {
        public UsuarioController(IUnitOfWork uow, IUsuarioRepository rep, IMapper mapper) : base(uow, rep, mapper)
        {
        }
    }
}
