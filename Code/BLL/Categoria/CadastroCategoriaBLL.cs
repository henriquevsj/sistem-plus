using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;

namespace SistemPlus.Code.BLL
{
    class CadastroCategoriaBLL
    {

        conexaoBD bd = new conexaoBD();

        public void InserirCategoria(CadastroCategoriaDTO dto)
        {
            try
            {
              
                bd.Conectar();
                string comando = "INSERT INTO Categoria (Categoria) VALUES ('" + dto.Categoria + "')";

                bd.ExecutarComandoSQL(comando);

                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                    throw new Exception("Erro no programa" + ex.Message);
            }

        }

    }
}
