using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemPlus.Code.DTO
{
    public class LoginDTO
    {
        private string user;
        private string senha;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
