using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.DTO;
using SistemPlus.Code.BLL;
using SistemPlus.Code.BLL.Embalagem;

namespace SistemPlus
{
    public partial class CadastroEmbalagem : Form
    {
        CadastroEmbalagemDTO DTOemb = new CadastroEmbalagemDTO();
        CadastroEmbalagemBLL BLLemb = new CadastroEmbalagemBLL();
        ExcluirEmbalagemBLL BLLExcEmb = new ExcluirEmbalagemBLL();
        AtualizarEmbalagemBLL BLLAtualEmb = new AtualizarEmbalagemBLL();
        

        PesquisaBLL BLLPesq = new PesquisaBLL();

        public CadastroEmbalagem()
        {
            InitializeComponent();
        }

        private void CadastroEmbalagem_Load(object sender, EventArgs e)
        {
            try
            {
                dtgEmbalagens.DataSource = BLLPesq.ExibirDadosEmbalagemDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtEmbalagens.Text == "")
            {
                MessageBox.Show("Preencha o campo embalagem");
            }
            else
            {
                try
                {
                    DTOemb.Embalagem = txtEmbalagens.Text;

                    BLLemb.InserirEmbalagem(DTOemb);

                    txtEmbalagens.Text = "";

                    try
                    {
                        dtgEmbalagens.DataSource = BLLPesq.ExibirDadosEmbalagemDAL();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exibir os dados" + ex);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados" + ex);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dtgEmbalagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgEmbalagens.Rows[rowIndex];

            this.txtId.Text = row.Cells[0].Value.ToString();
            this.txtEmbalagens.Text = row.Cells[1].Value.ToString();
        }    

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DTOemb.Id = int.Parse(txtId.Text);

            if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dtgEmbalagens.Rows.Remove(dtgEmbalagens.Rows[dtgEmbalagens.CurrentRow.Index]);
                BLLExcEmb.ExcluirEmbalagem(DTOemb);
            }

            txtId.Text = "";
            txtEmbalagens.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtEmbalagens.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um item para atualizar");
            }
            else
            {
                try
                {
                    dtgEmbalagens.DataSource = BLLPesq.ExibirDadosEmbalagemDAL();

                    if (MessageBox.Show("Deseja realmente atualizar o registro?", "Atualizacao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DTOemb.Id = int.Parse(txtId.Text);
                        DTOemb.Embalagem = txtEmbalagens.Text;
            
                        txtId.Text = "";
                        txtEmbalagens.Text = "";

                        BLLAtualEmb.AtualizarEmbalagem(DTOemb);
                    }

                    try
                    {
                        dtgEmbalagens.DataSource = BLLPesq.ExibirDadosEmbalagemDAL();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exibir os dados" + ex);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados" + ex);
                }
            }
        }

        private void cadastroDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedores CADfor = new CadastroFornecedores();
            CADfor.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CADpro = new CadastroProduto();
            CADpro.Show();
        }

        private void cadastroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCategoria cadCategoria = new CadastroCategoria();
            cadCategoria.Show();
        }
    }
}
