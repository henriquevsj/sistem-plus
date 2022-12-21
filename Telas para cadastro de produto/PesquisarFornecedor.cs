using SistemPlus.Code.BLL;
using SistemPlus.Code.DTO;
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
    public partial class PesquisarFornecedor : Form
    {
        CadastroProduto CadProdut = new CadastroProduto();
        PesquisaBLL BLLPesq = new PesquisaBLL();
        CadastroProdutoDTO DTOProd = new CadastroProdutoDTO();
        CadastroCategoriaDTO DTOCat = new CadastroCategoriaDTO();

        public PesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void dtgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgFornecedor.Rows[rowIndex];
        }

        private void PesquisarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                dtgFornecedor.DataSource = BLLPesq.ExibirDadosFornecedorDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadProdut.Closed += (s, args) => this.Close();
            CadProdut.Show();

            CadProdut.txtIdFornecedor.Text = this.dtgFornecedor.CurrentRow.Cells[0].Value.ToString();
            CadProdut.txtFornecedor.Text = this.dtgFornecedor.CurrentRow.Cells[1].Value.ToString();

            CadProdut.txtDescricao.Text = txtDescricao.Text;
            CadProdut.txtEmbalagem.Text = txtEmbalagem.Text;
            CadProdut.txtCategoria.Text = txtCategoria.Text;
            CadProdut.txtId.Text = txtId.Text;
            //CadProdut.txtFornecedor.Text = txtFornecedor.Text;


            CadProdut.txtIdCategoria.Text = txtIdCategoria.Text;
            CadProdut.txtIdEmbalagem.Text = txtIdEmbalagem.Text;
            //CadProdut.txtFornecedor.Text = txtFornecedor.Text;
        }
    }
}
