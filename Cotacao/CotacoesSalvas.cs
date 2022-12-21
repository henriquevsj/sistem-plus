using SistemPlus.Code.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Cotacao
{
    public partial class CotacoesSalvas : Form
    {
        conexaoBD bd = new conexaoBD();
        public CotacoesSalvas()
        {
            InitializeComponent();
        }

        private void CotacoesSalvas_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCotacoesSalvas.DataSource = bd.ExibirDadosCotacaoSalva();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Nova_Salva NovSal = new Nova_Salva();
            NovSal.Show();
            this.Close();
        }

        private void dtgCotacoesSalvas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgCotacoesSalvas.Rows[rowIndex];
        }
    }
}
