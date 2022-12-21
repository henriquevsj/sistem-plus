using SistemPlus.Code.BLL.Cotacao;
using SistemPlus.Cotacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus
{
    public partial class Nova_Salva : Form
    {
        NovaCotacaoBLL NovaCot = new NovaCotacaoBLL();
        Cotação Cot = new Cotação();

        public Nova_Salva()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal princ = new Principal();
            princ.Show();
            this.Close();
        }

        private void btnNovaCotação_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cot.Show();

            NovaCot.NovaCotacao();
        }

        private void btnCotSalvas_Click(object sender, EventArgs e)
        {
            CotacoesSalvas CotSal = new CotacoesSalvas();
            this.Hide();
            CotSal.Show();
        }
    }
}
