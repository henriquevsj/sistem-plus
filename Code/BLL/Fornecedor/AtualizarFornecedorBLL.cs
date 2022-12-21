using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemPlus.Code.DTO;
using SistemPlus.Code.DAL;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL.Fornecedor
{
    class AtualizarFornecedorBLL
    {
        conexaoBD bd = new conexaoBD();

        public void AtualizarFornecedor(CadastroFornecedorDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "UPDATE Fornecedor SET Nome = '" + dto.Nome + "', Telefone = '" + dto.Telefone + "', Email = '" + dto.Email + "', Empresa = '" + dto.Empresa + "' WHERE idFornecedor = " + dto.Id + ";";

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
