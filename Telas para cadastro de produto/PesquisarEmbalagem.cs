using SistemPlus.Code.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Telas_para_cadastro_de_produto
{
    public partial class PesquisarEmbalagem : Form
    {
        CadastroProduto CadProdut = new CadastroProduto();
        PesquisaBLL BLLPesq = new PesquisaBLL();

        public PesquisarEmbalagem()
        {
            InitializeComponent();
        }

        private void dtgEmbalagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgEmbalagem.Rows[rowIndex];

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadProdut.Closed += (s, args) => this.Close();
            CadProdut.Show();

            CadProdut.txtIdEmbalagem.Text = this.dtgEmbalagem.CurrentRow.Cells[0].Value.ToString();
            CadProdut.txtEmbalagem.Text = this.dtgEmbalagem.CurrentRow.Cells[1].Value.ToString();


            CadProdut.txtId.Text = txtId.Text;

            CadProdut.txtDescricao.Text = txtDescricao.Text;
            //CadProdut.txtEmbalagem.Text = txtEmbalagem.Text;
            CadProdut.txtCategoria.Text = txtCategoria.Text;
            CadProdut.txtFornecedor.Text = txtFornecedor.Text;


            CadProdut.txtIdCategoria.Text = txtIdCategoria.Text;
            //CadProdut.txtIdEmbalagem.Text = txtIdEmbalagem.Text;
            CadProdut.txtFornecedor.Text = txtFornecedor.Text;
        }

        private void PesquisarEmbalagem_Load(object sender, EventArgs e)
        {
            try
            {
                dtgEmbalagem.DataSource = BLLPesq.ExibirDadosEmbalagemDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }
    }
}
