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
using SistemPlus.Code.BLL.Categoria;
using SistemPlus.Code.BLL;

namespace SistemPlus
{
    public partial class CadastroCategoria : Form
    {
        CadastroCategoriaDTO DTOCat = new CadastroCategoriaDTO();
        CadastroCategoriaBLL BLLCat = new CadastroCategoriaBLL();
        ExcluirCategoriaBLL BLLExcCat = new ExcluirCategoriaBLL();
        AtualizarCategoriaBLL BLLAtuaCat = new AtualizarCategoriaBLL();

        PesquisaBLL BLLPesq = new PesquisaBLL();

        public CadastroCategoria()
        {
            InitializeComponent();
        }

        private void CadastroCategoria_Load(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else
            {
                try
                {

                    DTOCat.Categoria = txtCategoria.Text;
                    BLLCat.InserirCategoria(DTOCat);
                    txtCategoria.Text = "";
                    try
                    {
                        dtgCategoria.DataSource = BLLPesq.ExibirDadosCategoriaDAL();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgCategoria.Rows[rowIndex];

            this.txtId.Text = row.Cells[0].Value.ToString();
            this.txtCategoria.Text = row.Cells[1].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um item para excluir");
            }
            else
            {
                DTOCat.Id = int.Parse(txtId.Text);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtgCategoria.Rows.Remove(dtgCategoria.Rows[dtgCategoria.CurrentRow.Index]);
                    BLLExcCat.ExcluirCategoria(DTOCat);
                }

                txtId.Text = "";
                txtCategoria.Text = "";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um intem para atualizar");
            }
            else
            {
                try
                {
                    dtgCategoria.DataSource = BLLPesq.PesquisarFornecedorDAL();

                    if (MessageBox.Show("Deseja realmente atualizar o registro?", "Atualizacao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DTOCat.Id = int.Parse(txtId.Text);
                        DTOCat.Categoria = txtCategoria.Text;
                       

                        txtId.Text = "";
                        txtCategoria.Text = "";


                        BLLAtuaCat.AtualizarCategoria(DTOCat);
                    }

                    try
                    {
                        dtgCategoria.DataSource = BLLPesq.ExibirDadosCategoriaDAL();
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

        private void cadastroDeEmbalagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmbalagem CADemb = new CadastroEmbalagem();
            CADemb.Show();
        }
    }
}
