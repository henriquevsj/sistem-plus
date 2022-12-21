using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemPlus.Code.DTO;
using SistemPlus.Code.DAL;
using System.Windows.Forms;
using SistemPlus;

namespace SistemPlus.Code.BLL.Fornecedor
{
    class ExcluirFornecedorBLL
    {
        conexaoBD bd = new conexaoBD();
 
        public void ExcluirFornecedor(CadastroFornecedorDTO dTOForn)
        {
            try
            {

                bd.Conectar();
                string comando = "DELETE FROM fornecedor WHERE idFornecedor = '" + dTOForn.Id + "';";

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
