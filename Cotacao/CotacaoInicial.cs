using SistemPlus.Code.BLL;
using SistemPlus.Code.BLL.Cotacao;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using SistemPlus.Cotacao;
using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace SistemPlus
{
    public partial class Cotação : Form
    {
        
        PesquisaBLL BLLPesq = new PesquisaBLL();
        SelecionarMaximoIdBLL BLLMax = new SelecionarMaximoIdBLL();
        ExcluirUltimaCotacaoBLL BLLExcUltCot = new ExcluirUltimaCotacaoBLL();
        CadastroProdutoCotacaoDTO DTOCadProCot = new CadastroProdutoCotacaoDTO();
        EcluirProdutoCotacaoBLL BLLExcProdCot = new EcluirProdutoCotacaoBLL();

        CotacaoDTO DTOCot = new CotacaoDTO();
        conexaoBD bd = new conexaoBD();

        //Form1 frm = new Form();

        public Cotação()
        {
            InitializeComponent();

        }

        private void Cotação_Load(object sender, EventArgs e)
        {

            bd.MaiorId(DTOCot);

            txtId.Text = DTOCot.Id.ToString();

            try
            {
                dtgCotacao.DataSource = bd.ExibirDadosCotacao(DTOCot);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir os dados" + ex);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DTOCot.Id = int.Parse(txtId.Text);

            if (MessageBox.Show("Deseja sair sem salva a cotação?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BLLExcUltCot.ExcluirUltima(DTOCot);
                Nova_Salva NovSal = new Nova_Salva();
                NovSal.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Certo, continue realizando a cotação! ");
            }


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dtgCotacao.Rows[rowIndex];
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            this.Hide();

            SelecionarProdutoCotacao SelProd = new SelecionarProdutoCotacao();
            SelProd.Closed += (s, args) => this.Close();
            SelProd.Show();

            SelProd.txtIdCotacao.Text = txtId.Text;
        }
    
        private void btnPlanilha_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // novo

            Excel.Application App; // Aplicação Excel

            Excel.Workbook WorkBook; // Pasta

            Excel.Worksheet WorkSheet; // Planilha

            object misValue = System.Reflection.Missing.Value;



            App = new Excel.Application();

            WorkBook = App.Workbooks.Add(misValue);

            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);

            int i = 0;

            int j = 0;



            // passa as celulas do DataGridView para a Pasta do Excel

            for (int c = 1; c< dtgCotacao.ColumnCount + 1; c++)
            {
                WorkSheet.Cells[1, c] = dtgCotacao.Columns[c - 1].HeaderText;
            }

            for (i = 0; i <= dtgCotacao.RowCount - 1; i++)

            {

                for (j = 0; j <= dtgCotacao.ColumnCount - 1; j++)

                {

                    DataGridViewCell cell = dtgCotacao[j, i];

                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;

                }

            }



            // define algumas propriedades da caixa salvar

            salvar.Title = "Exportar para Excel";

            salvar.Filter = "Arquivo do Excel *.xls | *.xls";

            salvar.ShowDialog(); // mostra



            // salva o arquivo

            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,



            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            WorkBook.Close(true, misValue, misValue);

            App.Quit(); // encerra o excel



            MessageBox.Show("Exportado com sucesso!");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dtgCotacao.Width, this.dtgCotacao.Height);
            dtgCotacao.DrawToBitmap(bm, new Rectangle(0, 0, this.dtgCotacao.Width, this.dtgCotacao.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
            

            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um item para excluir");
            }
            else
            {
                DTOCadProCot.Id = Convert.ToInt32(dtgCotacao.CurrentRow.Cells[0].Value);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtgCotacao.Rows.Remove(dtgCotacao.Rows[dtgCotacao.CurrentRow.Index]);
                    BLLExcProdCot.ExcluirProdutoCotacao(DTOCadProCot);
                }

                DTOCadProCot.Id = 0;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cotação salva!");

            this.Close();

            Nova_Salva NovSal = new Nova_Salva();
            NovSal.Show();
            this.Close();
        }
    }
}
