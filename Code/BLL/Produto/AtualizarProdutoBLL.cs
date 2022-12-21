using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL.Produto
{
    class AtualizarProdutoBLL
    {
        conexaoBD bd = new conexaoBD();

        public void AtualizarProduto(CadastroProdutoDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "UPDATE Produto SET Descricao = '" + dto.Descricao + "', Categoria_idCategoria = '" + dto.Categoria_idCategoria + "',  Fornecedor_idFornecedor = '" + dto.Fornecedor_idFornecedor + "', Embalagem_idEmbalagem = '" + dto.Embalagem_idEmbalagem + "' WHERE idProduto = " + dto.Id + ";";

                bd.ExecutarComandoSQL(comando);

                MessageBox.Show("Atualizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro no programa" + ex.Message);
            }

        }
    }
}
