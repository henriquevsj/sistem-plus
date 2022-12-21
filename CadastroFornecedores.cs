using System;
using System.Windows.Forms;
using SistemPlus.Code.BLL;
using SistemPlus.Code.BLL.Fornecedor;
using SistemPlus.Code.DTO;

namespace SistemPlus
{
    public partial class CadastroFornecedores : Form
    {
        CadastroFornecedorDTO DTOForn = new CadastroFornecedorDTO();
        CadastroFornecedorBLL BLLCadForn = new CadastroFornecedorBLL();
        AtualizarFornecedorBLL BLLAtuaForn = new AtualizarFornecedorBLL();
        ExcluirFornecedorBLL BLLExcForn = new ExcluirFornecedorBLL();
        PesquisaBLL BLLPesq = new PesquisaBLL();

      

        public CadastroFornecedores()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroFornecedores_Load(object sender, EventArgs e)
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                dtgFornecedor.DataSource = BLLPesq.PesquisarFornecedorDAL();
            }
            catch( Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
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
                DTOForn.Id = int.Parse(txtId.Text);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtgFornecedor.Rows.Remove(dtgFornecedor.Rows[dtgFornecedor.CurrentRow.Index]);
                    BLLExcForn.ExcluirFornecedor(DTOForn);
                }

                txtId.Text = "";
                txtNome.Text = "";
                txtEmpresa.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
            }
        }

        private void dtgFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgFornecedor.Rows[rowIndex];

            this.txtId.Text = row.Cells[0].Value.ToString();
            this.txtNome.Text = row.Cells[1].Value.ToString();
            this.txtTelefone.Text = row.Cells[2].Value.ToString();
            this.txtEmail.Text = row.Cells[3].Value.ToString();
            this.txtEmpresa.Text = row.Cells[4].Value.ToString();
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
                    dtgFornecedor.DataSource = BLLPesq.ExibirDadosFornecedorDAL();

                    if (MessageBox.Show("Deseja realmente atualizar o registro?", "Atualizacao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DTOForn.Id = int.Parse(txtId.Text);
                        DTOForn.Nome = txtNome.Text;
                        DTOForn.Telefone = int.Parse(txtTelefone.Text);
                        DTOForn.Empresa = txtEmpresa.Text;
                        DTOForn.Email = txtEmail.Text;

                        txtId.Text = "";
                        txtNome.Text = "";
                        txtEmpresa.Text = "";
                        txtTelefone.Text = "";
                        txtEmail.Text = "";

                        BLLAtuaForn.AtualizarFornecedor(DTOForn);
                    }

                    try
                    {
                        dtgFornecedor.DataSource = BLLPesq.ExibirDadosFornecedorDAL();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exibir os dados " + ex);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados 2 " + ex);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEmpresa.Text = "";
            txtTelefone.Text = "";
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;

            if (e.KeyChar == 13)
            {
                if (txtId.Text == "")
                {
                    this.AcceptButton = btnCadastrar;
                }
            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               if (txtId.Text == "")
                {
                    this.AcceptButton = btnCadastrar;
                }
            }

        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtId.Text == "")
                {
                    this.AcceptButton = btnCadastrar;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else if (txtEmpresa.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                DTOForn.Nome = txtNome.Text;
                DTOForn.Telefone = int.Parse(txtTelefone.Text);
                DTOForn.Empresa = txtEmpresa.Text;
                DTOForn.Email = txtEmail.Text;

                BLLCadForn.InserirFornecedor(DTOForn);

                txtNome.Text = "";
                txtEmpresa.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";

                try
                {
                    dtgFornecedor.DataSource = BLLPesq.ExibirDadosFornecedorDAL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados " + ex);
                }
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtId.Text == "")
                {
                    this.AcceptButton = btnCadastrar;
                }
            }
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto CADpro = new CadastroProduto();
            CADpro.Show();
        }

        private void cadastroDeEmbalagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmbalagem CADemb = new CadastroEmbalagem();
            CADemb.Show();
        }

        private void cadastroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCategoria cadCategoria = new CadastroCategoria();
            cadCategoria.Show();
        }

        private void dtgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
