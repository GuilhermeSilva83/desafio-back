using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.UserApi.ViewModel
{
    public class LoginVM
    {
        private string apelido;

        public string Apelido
        {
            get => apelido;
            set
            {
                apelido = value?.ToLower();
            }
        }
        public string Senha { get; set; }
    }
}
