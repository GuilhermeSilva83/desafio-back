using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Desafio.Domain.MembershipContext.UsuarioAgg;
using Desafio.Seedwork.Domain;
using Desafio.UserApi.Infra;
using Desafio.UserApi.ViewModel;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Desafio.UserApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private AuthService service;
        public UsuarioController(AuthService service)
        {
            this.service = service;
        }

        [HttpPost("login")]
        public ActionResult<OperationResult<string>> LogInt([FromBody] LoginVM vm)
        {
            return Ok(service.AutenticarAtivo(vm));
        }
    }
}
