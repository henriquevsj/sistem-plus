using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemPlus.Code.DTO
{
    class CotacaoDTO
    {
        private int id;
        private DateTime Data;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data1 { get => Data; set => Data = value; }
    }
}
