using Desafio.Domain.MembershipContext.UsuarioAgg;
using Desafio.Seedwork.Domain;
using Desafio.UserApi.ViewModel;

using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.UserApi.Infra
{
    public class AuthService
    {
        private readonly byte[] key;
        private readonly IUsuarioRepository repository;

        public AuthService(string key, IUsuarioRepository repository)
        {

            this.key = Encoding.ASCII.GetBytes(key);
            this.repository = repository;
        }


        public OperationResult<string> AutenticarAtivo(LoginVM vm)
        {
            if (vm.Apelido == null || vm.Senha == null)
            {
                return OperationResult.Fail<string>("Campos não preenchidos");
            }

            var usuario = repository.Get(vm.Apelido, vm.Senha);

            if (usuario == null)
            {
                return OperationResult.Fail<string>("Usuário não encontrado ou senha inválida.");
            }


            var handler = new JwtSecurityTokenHandler();

            var descriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,usuario.Apelido),
                    new Claim(ClaimTypes.Sid, usuario.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };


            var desc = handler.CreateToken(descriptor);

            var tokenString = handler.WriteToken(desc);

            return OperationResult.Ok(tokenString);
        }
    }
}
