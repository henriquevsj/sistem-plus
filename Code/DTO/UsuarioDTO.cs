using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia_Vila_Bela.Code.DTO
{
    [DataContract()]
    [Serializable()]

    class CadastroFornecedorDTO
    {
        private int id;
        private string nome;
        private int numero;
        private string empresa;

        [DataMember(), Key(), Required()]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
    }
}
