using SistemPlus.Code.BLL;
using SistemPlus.Code.BLL.Cotacao;
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

namespace SistemPlus.Cotacao
{

    public partial class SelecionarProdutoCotacao : Form
    {
        public SelecionarProdutoCotacao()
        {
            InitializeComponent();
        }

        PesquisaBLL BLLPesq = new PesquisaBLL();
        CadastroProdutoCotacaoBLL BLLCadProdCot = new CadastroProdutoCotacaoBLL();
        CadastroProdutoCotacaoDTO DTOCadProdCot = new CadastroProdutoCotacaoDTO();
        Cotação Cot = new Cotação();


        private void SelecionarProduto_Load(object sender, EventArgs e)
        {
            try
            {
                dtgSelecionarProduto.DataSource = BLLPesq.ExibirDadosProdutoDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void dtgSelecionarProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgSelecionarProduto.Rows[rowIndex];


        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {


            txtIdProduto.Text = this.dtgSelecionarProduto.CurrentRow.Cells[0].Value.ToString();
            txtIdCategoria.Text = this.dtgSelecionarProduto.CurrentRow.Cells[6].Value.ToString();
            txtIdEmbalagem.Text = this.dtgSelecionarProduto.CurrentRow.Cells[7].Value.ToString();

            DTOCadProdCot.Produto_idproduto = int.Parse(txtIdProduto.Text);
            DTOCadProdCot.Categoria_idcategoria = int.Parse(txtIdCategoria.Text);
            DTOCadProdCot.Embalagem_idembalagem = int.Parse(txtIdEmbalagem.Text);


            DTOCadProdCot.Cotacao_idcotacao = int.Parse(txtIdCotacao.Text);

            BLLCadProdCot.InserirProdutoCotacao(DTOCadProdCot);


            this.Hide();
            Cot.Closed += (s, args) => this.Close();
            Cot.Show();
            
            
        }

        /*private void dtgSelecionarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtIdProduto.Text = this.dtgSelecionarProduto.CurrentRow.Cells[0].Value.ToString();
                DTOCadProdCot.Produto_idproduto = int.Parse(txtIdProduto.Text);
                DTOCadProdCot.Cotacao_idcotacao = int.Parse(txtIdCotacao.Text);
                BLLCadProdCot.InserirProdutoCotacao(DTOCadProdCot);


                this.Hide();
                Cot.Closed += (s, args) => this.Close();
                Cot.Show();
            }
        }
        */
    }
}
