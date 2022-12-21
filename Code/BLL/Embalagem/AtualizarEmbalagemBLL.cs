using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL.Embalagem
{
    class AtualizarEmbalagemBLL
    {
        conexaoBD bd = new conexaoBD();

        public void AtualizarEmbalagem(CadastroEmbalagemDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "UPDATE embalagem SET Emb_compra = '" + dto.Embalagem + "' WHERE idEmbalagem = '" + dto.Id + "';";

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
