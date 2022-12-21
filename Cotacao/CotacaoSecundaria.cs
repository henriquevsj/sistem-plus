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
using SistemPlus.Code.BLL.Cotacao;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using SistemPlus.Cotacao;
using MySql.Data.MySqlClient;


namespace SistemPlus.Cotacao
{
    public partial class CotacaoSecundaria : Form
    {
        public CotacaoSecundaria()
        {
            InitializeComponent();
        }
        CotacaoDTO CotDTO = new CotacaoDTO();
        PesquisaBLL BLLPesq = new PesquisaBLL();
        conexaoBD bd = new conexaoBD();

        private void CotacaoSecundaria_Load(object sender, EventArgs e)
        {
            bd.Conectar();
            MySqlConnection conexao = new MySqlConnection("server=localhost; User=root; database=Mercearia; password=;");
            conexao.Open();

            MySqlCommand selcon = new MySqlCommand("SELECT idCotacao FROM cotacao ORDER BY idCotacao DESC limit 1;", conexao);
            MySqlDataReader rdr;


            rdr = selcon.ExecuteReader();
            rdr.Read();

            CotDTO.Id = rdr.GetInt32(0);


        }


        private void dtgCotacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgCotacaoSecundaria.Rows[rowIndex];

        }

        private void btnSelecionarProduto_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            SelecionarProdutoCotacao SelProd = new SelecionarProdutoCotacao();
            SelProd.Closed += (s, args) => this.Close();
            SelProd.Show();

            SelProd.txtIdCotacao.Text = txtId.Text;


            /*if (MessageBox.Show("Item selecionado", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    dtgCotacaoSecundaria.DataSource = BLLPesq.ExibirDadosCotacaoDAL();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados " + ex);
                }
            }*/
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Principal princ = new Principal();
            princ.Show();
            this.Close();
        }
    }
}
