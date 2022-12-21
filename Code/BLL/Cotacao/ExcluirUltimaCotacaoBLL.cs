using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL.Cotacao
{
    class ExcluirUltimaCotacaoBLL
    {
        conexaoBD bd = new conexaoBD();

        public void ExcluirUltima(CotacaoDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "DELETE FROM cotacao WHERE idCotacao = '" + dto.Id + "';";

                bd.ExecutarComandoSQL(comando);

            }

            catch (Exception ex)
            {
                throw new Exception("Erro no programa" + ex.Message);
            }
        }
    }
}
