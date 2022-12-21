using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL.Categoria
{
    class ExcluirCategoriaBLL
    {
        conexaoBD bd = new conexaoBD();

        public void ExcluirCategoria(CadastroCategoriaDTO dTOCat)
        {
            try
            {

                bd.Conectar();
                string comando = "DELETE FROM categoria WHERE idCategoria = '" + dTOCat.Id + "';";

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
