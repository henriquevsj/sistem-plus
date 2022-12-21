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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal princ = new Principal();
            princ.Show();
            this.Close();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto cadFornecedor = new CadastroProduto();
            cadFornecedor.Show();
        }

        private void btnCadFornecedores_Click(object sender, EventArgs e)
        {
            CadastroFornecedores cadFornecedor = new CadastroFornecedores();
            cadFornecedor.Show();
        }

        private void btnCadEmbalagens_Click(object sender, EventArgs e)
        {
            CadastroEmbalagem CADemb = new CadastroEmbalagem();
            CADemb.Show();
        }

        private void btnCadCategorias_Click(object sender, EventArgs e)
        {
            CadastroCategoria cadCategoria = new CadastroCategoria();
            cadCategoria.Show();
        }
    }
}
