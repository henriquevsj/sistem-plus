using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemPlus.Code.DAL;

namespace SistemPlus.Code.DTO
{
    class CadastroEmbalagemDTO
    {
        private int id;
        private string embalagem;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Embalagem
        {
            get { return embalagem; }
            set { embalagem = value; }
        }
    }
}
