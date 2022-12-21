using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemPlus.Code.DTO
{
    public class CadastroProdutoDTO
    {
        private int id;
        private string descricao;
        private int categoria_idCategoria;
        private int embalagem_idEmbalagem;
        private int fornecedor_idFornecedor;


        public int Id
        {
            get { return id;  }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Categoria_idCategoria { get => categoria_idCategoria; set => categoria_idCategoria = value; }
        public int Embalagem_idEmbalagem { get => embalagem_idEmbalagem; set => embalagem_idEmbalagem = value; }
        public int Fornecedor_idFornecedor { get => fornecedor_idFornecedor; set => fornecedor_idFornecedor = value; }
    }
}
