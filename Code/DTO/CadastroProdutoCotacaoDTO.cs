using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemPlus.Code.DTO
{
    class CadastroProdutoCotacaoDTO
    {
        private int id;
        private int produto_idproduto;
        private int cotacao_idcotacao;
        private int embalagem_idembalagem;
        private int categoria_idcategoria;

        public int Id { get => id; set => id = value; }
        public int Produto_idproduto { get => produto_idproduto; set => produto_idproduto = value; }
        public int Cotacao_idcotacao { get => cotacao_idcotacao; set => cotacao_idcotacao = value; }
        public int Embalagem_idembalagem { get => embalagem_idembalagem; set => embalagem_idembalagem = value; }
        public int Categoria_idcategoria { get => categoria_idcategoria; set => categoria_idcategoria = value; }
    }
}
