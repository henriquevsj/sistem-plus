using SistemPlus.Code.BLL;
using SistemPlus.Code.BLL.Cotacao;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using MySql.Data.MySqlClient;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        NovaCotacaoBLL NovaCot = new NovaCotacaoBLL();
        Cotação Cot = new Cotação();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadPrdoduto = new CadastroProduto();
            cadPrdoduto.Show(); 
        }

        private void visualizarCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadPrdoduto = new CadastroProduto();
            cadPrdoduto.Show();
        }



        private void embalagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmbalagem CADemb = new CadastroEmbalagem();
            CADemb.Show();
        }


        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedores cadFornecedor = new CadastroFornecedores();
            cadFornecedor.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCategoria cadCategoria = new CadastroCategoria();
            cadCategoria.Show();
        }

        private void btnTelaCadastros_Click(object sender, EventArgs e)
        {
            
            Cadastros cadCategoria = new Cadastros();
            this.Hide();
            cadCategoria.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }

        private void btnCotacao_Click(object sender, EventArgs e)
        {
            Nova_Salva NovSal = new Nova_Salva();
            this.Hide();
            NovSal.Show();
        }
    }
}
