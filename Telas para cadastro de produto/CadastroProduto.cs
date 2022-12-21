using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.BLL;
using SistemPlus.Code.BLL.Produto;
using SistemPlus.Code.DTO;
using SistemPlus.Telas_para_cadastro_de_produto;

namespace SistemPlus
{
    public partial class CadastroProduto : Form
    {
        CadastroProdutoBLL BLLCadProd = new CadastroProdutoBLL();
        ExcluirProdutoBLL BLLExcProd = new ExcluirProdutoBLL();
        AtualizarProdutoBLL BLLAtualProd = new AtualizarProdutoBLL();
        PesquisaBLL BLLPesq = new PesquisaBLL();

        CadastroProdutoDTO DTOProd = new CadastroProdutoDTO();



        public CadastroProduto()
        {
            InitializeComponent();
        }



        private void CadastroProduto_Load(object sender, EventArgs e)
        {

            try
            {
                dtgProduto.DataSource = BLLPesq.ExibirDadosProdutoDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else if (txtCategoria.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else if (txtEmbalagem.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (txtFornecedor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
           
            else
            {
                DTOProd.Descricao = txtDescricao.Text;
                DTOProd.Categoria_idCategoria = int.Parse(txtIdCategoria.Text);
                DTOProd.Embalagem_idEmbalagem = int.Parse(txtIdEmbalagem.Text);
                DTOProd.Fornecedor_idFornecedor = int.Parse(txtIdFornecedor.Text);

                BLLCadProd.Inserir(DTOProd);

                txtDescricao.Text = "";
                txtIdFornecedor.Text = "";
                txtIdEmbalagem.Text = "";
                txtIdCategoria.Text = "";

                txtFornecedor.Text = "";
                txtEmbalagem.Text = ""; 
                txtCategoria.Text = "";
           }

            try
            {
                dtgProduto.DataSource = BLLPesq.ExibirDadosProdutoDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    dtgProduto.DataSource = BLLPesq.ExibirDadosProdutoDAL();

                    if (MessageBox.Show("Deseja realmente atualizar o registro?", "Atualizacao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DTOProd.Id = int.Parse(txtId.Text);
                        DTOProd.Descricao = txtDescricao.Text;
                        DTOProd.Fornecedor_idFornecedor = int.Parse(txtIdFornecedor.Text);
                        DTOProd.Embalagem_idEmbalagem = int.Parse(txtIdEmbalagem.Text);
                        DTOProd.Categoria_idCategoria = int.Parse(txtIdCategoria.Text);


                        txtId.Text = "";
                        txtDescricao.Text = "";

                        BLLAtualProd.AtualizarProduto(DTOProd);
                    }

                    try
                    {
                        dtgProduto.DataSource = BLLPesq.ExibirDadosProdutoDAL();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um item para excluir");
            }

            else
            {
                DTOProd.Id = int.Parse(txtId.Text);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtgProduto.Rows.Remove(dtgProduto.Rows[dtgProduto.CurrentRow.Index]);
                    BLLExcProd.ExcluirProduto(DTOProd);
                }

                txtId.Text = "";
                txtDescricao.Text = "";
                txtCategoria.Text = "";
                txtEmbalagem.Text = "";
                txtFornecedor.Text = "";
                txtIdCategoria.Text = "";
                txtIdEmbalagem.Text = "";
                txtIdFornecedor.Text = "";
               
            }

            try
            {
                dtgProduto.DataSource = BLLPesq.ExibirDadosProdutoDAL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    

        public void btnPesquisarCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();

            PesquisarCategoria PesqCategoria = new PesquisarCategoria();
            PesqCategoria.Closed += (s, args) => this.Close();
            PesqCategoria.Show();


            PesqCategoria.txtId.Text = txtId.Text;
            PesqCategoria.txtDescricao.Text = txtDescricao.Text;
            PesqCategoria.txtCategoria.Text = txtCategoria.Text;
            PesqCategoria.txtEmbalagem.Text = txtEmbalagem.Text;
            PesqCategoria.txtFornecedor.Text = txtFornecedor.Text;

            PesqCategoria.txtIdCategoria.Text = txtIdCategoria.Text;
            PesqCategoria.txtIdEmbalagem.Text = txtIdEmbalagem.Text;
            PesqCategoria.txtIdFornecedor.Text = txtIdFornecedor.Text;
        }

        private void btnPesquisarEmbalagem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarEmbalagem PesqEmbalagem = new PesquisarEmbalagem();
            PesqEmbalagem.Closed += (s, args) => this.Close();
            PesqEmbalagem.Show();

            PesqEmbalagem.txtId.Text = txtId.Text;
            PesqEmbalagem.txtDescricao.Text = txtDescricao.Text;
            PesqEmbalagem.txtCategoria.Text = txtCategoria.Text;
            PesqEmbalagem.txtEmbalagem.Text = txtEmbalagem.Text;
            PesqEmbalagem.txtFornecedor.Text = txtFornecedor.Text;

            PesqEmbalagem.txtIdCategoria.Text = txtIdCategoria.Text;
            PesqEmbalagem.txtIdEmbalagem.Text = txtIdEmbalagem.Text;
            PesqEmbalagem.txtIdFornecedor.Text = txtIdFornecedor.Text;
        }

        private void btnPesquisarCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarFornecedor PesqFornecedor = new PesquisarFornecedor();
            PesqFornecedor.Closed += (s, args) => this.Close();
            PesqFornecedor.Show();

            PesqFornecedor.txtId.Text = txtId.Text;
            PesqFornecedor.txtDescricao.Text = txtDescricao.Text;
            PesqFornecedor.txtCategoria.Text = txtCategoria.Text;
            PesqFornecedor.txtEmbalagem.Text = txtEmbalagem.Text;
            PesqFornecedor.txtFornecedor.Text = txtFornecedor.Text;

            PesqFornecedor.txtIdCategoria.Text = txtIdCategoria.Text;
            PesqFornecedor.txtIdEmbalagem.Text = txtIdEmbalagem.Text;
            PesqFornecedor.txtIdFornecedor.Text = txtIdFornecedor.Text;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastroDeEmbalagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmbalagem CADemb = new CadastroEmbalagem();
            CADemb.Show();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedores cadFornecedor = new CadastroFornecedores();
            cadFornecedor.Show();
        }

        private void cadastroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCategoria cadCategoria = new CadastroCategoria();
            cadCategoria.Show();
        }

        private void dtgProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgProduto.Rows[rowIndex];

            try
            {
                this.txtId.Text = row.Cells[0].Value.ToString();
                this.txtDescricao.Text = row.Cells[1].Value.ToString();
                this.txtIdFornecedor.Text = row.Cells[5].Value.ToString();
                this.txtIdCategoria.Text = row.Cells[6].Value.ToString();
                this.txtIdEmbalagem.Text = row.Cells[7].Value.ToString();

                this.txtFornecedor.Text = row.Cells[2].Value.ToString();
                this.txtCategoria.Text = row.Cells[3].Value.ToString();
                this.txtEmbalagem.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex);
            }
        }
    }
}
