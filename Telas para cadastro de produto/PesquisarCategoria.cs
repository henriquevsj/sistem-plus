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
using static SistemPlus.CadastroProduto;

namespace SistemPlus.Telas_para_cadastro_de_produto
{
    public partial class PesquisarCategoria : Form
    {
        CadastroProduto CadProdut = new CadastroProduto();
        PesquisaBLL BLLPesq = new PesquisaBLL();
        CadastroProdutoDTO DTOProd = new CadastroProdutoDTO();
        CadastroCategoriaDTO DTOCat = new CadastroCategoriaDTO();

        public PesquisarCategoria()
        {
            InitializeComponent();
        }

       

        private void dtgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgCategoria.Rows[rowIndex];
      
        }

        private void PesquisarCategoria_Load(object sender, EventArgs e)
        {


            try
            {
                dtgCategoria.DataSource = BLLPesq.ExibirDadosCategoriaDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            // Atençao senhor programador, isto é uma gambiarra! Favor avisar antes de alterar. Obrigado!
            this.Hide();
            CadProdut.Closed += (s, args) => this.Close();
            CadProdut.Show();

            CadProdut.txtIdCategoria.Text = this.dtgCategoria.CurrentRow.Cells[0].Value.ToString();
            CadProdut.txtCategoria.Text = this.dtgCategoria.CurrentRow.Cells[1].Value.ToString();


            CadProdut.txtId.Text = txtId.Text;

            CadProdut.txtDescricao.Text = txtDescricao.Text;
            CadProdut.txtEmbalagem.Text = txtEmbalagem.Text;
            //CadProdut.txtCategoria.Text = txtCategoria.Text;
            CadProdut.txtFornecedor.Text = txtFornecedor.Text;


           // CadProdut.txtIdCategoria.Text = txtIdCategoria.Text;
            CadProdut.txtIdEmbalagem.Text = txtIdEmbalagem.Text;
            CadProdut.txtIdFornecedor.Text = txtIdFornecedor.Text;


        }
    }
}
