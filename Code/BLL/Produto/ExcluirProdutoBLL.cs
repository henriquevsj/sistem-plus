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
    class ExcluirProdutoBLL
    {
        conexaoBD bd = new conexaoBD();

        public void ExcluirProduto(CadastroProdutoDTO DtoPro)
        {
            try
            {
                bd.Conectar();
                string comando = "DELETE FROM produto WHERE idProduto = '" + DtoPro.Id + "';";

                bd.ExecutarComandoSQL(comando);

                MessageBox.Show("Excluido com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                throw new Exception("Erro no programa" + ex.Message);
            }
        }
    }
}
