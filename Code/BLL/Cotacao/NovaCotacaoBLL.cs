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
    class NovaCotacaoBLL
    {
        conexaoBD bd = new conexaoBD();
        Cotação cot = new Cotação();

        public void NovaCotacao()
        {
            try
            {
                bd.Conectar();
                string comando = "INSERT INTO Cotacao VALUES ();";

                bd.ExecutarComandoSQL(comando);
                MessageBox.Show("Nova cotação iniciada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro no programa" + ex.Message);
            }

        }
    }
}
