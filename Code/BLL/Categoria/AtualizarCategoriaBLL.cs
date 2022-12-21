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
    class AtualizarCategoriaBLL
    {
        conexaoBD bd = new conexaoBD();

        public void AtualizarCategoria(CadastroCategoriaDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "UPDATE categoria SET Categoria = '" + dto.Categoria + "' WHERE idCategoria = '" + dto.Id + "';";

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

