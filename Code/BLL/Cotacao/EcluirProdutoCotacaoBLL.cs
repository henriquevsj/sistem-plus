using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;

namespace SistemPlus.Code.BLL.Cotacao
{
    class EcluirProdutoCotacaoBLL
    {
        conexaoBD bd = new conexaoBD();

        public void ExcluirProdutoCotacao(CadastroProdutoCotacaoDTO dto)
        {
            try
            {

                bd.Conectar();
                string comando = "DELETE FROM produto_cotacao WHERE idProduto_cotacao = '" + dto.Id + "';";

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
