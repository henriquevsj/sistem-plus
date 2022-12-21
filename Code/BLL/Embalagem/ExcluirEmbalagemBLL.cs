using SistemPlus.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.DTO;


namespace SistemPlus.Code.BLL.Embalagem
{
    class ExcluirEmbalagemBLL
    {
        conexaoBD bd = new conexaoBD();

        public void ExcluirEmbalagem(CadastroEmbalagemDTO dTOEmb)
        {
            try
            {
                bd.Conectar();
                string comando = "DELETE FROM embalagem WHERE idEmbalagem = '" + dTOEmb.Id + "';";

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

