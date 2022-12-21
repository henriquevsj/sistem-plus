using System;
using System.Windows.Forms;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;

namespace SistemPlus.Code.BLL
{
    class CadastroFornecedorBLL
    {
        conexaoBD bd = new conexaoBD();

        public void InserirFornecedor (CadastroFornecedorDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "INSERT INTO Fornecedor (Nome, Telefone, Empresa, Email) VALUES ('" + dto.Nome +"','"+ dto.Telefone +"','"+dto.Empresa+"','"+dto.Email+"')";

                bd.ExecutarComandoSQL(comando);
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro no programa"+ ex.Message);
            }

        }
    }
}
