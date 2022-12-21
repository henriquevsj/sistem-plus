using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SistemPlus.Code.DTO;
using System.Data.SqlClient;

using System.ComponentModel;
using System.Configuration;
using SistemPlus.Cotacao;

namespace SistemPlus.Code.DAL
{
    class conexaoBD
    {
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlCommand comando = new MySqlCommand();
        DataTable dt = new DataTable();
        CotacaoDTO CotDTO = new CotacaoDTO();


        MySqlConnection conexao = new MySqlConnection("server=localhost; User=root; database=mercearia; password=;");


        public void Conectar()
        {
            if (conexao != null)
                conexao.Close();
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível estabelecer conexão. " + ex.Message);
            }

        }

        public void ExecutarComandoSQL(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        /*--------------------------------------------------------------------------------------------*/

        public DataTable ExibirDadosFornecedor()
        {
            CadastroFornecedorDTO dto = new CadastroFornecedorDTO();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Fornecedor;", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable PesquisaFornecedor()
        {
            CadastroFornecedorDTO dto = new CadastroFornecedorDTO();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM fornecedor WHERE Nome " + dto.Nome + ";", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosEmbalagens()
        {
            CadastroCategoriaDTO dto = new CadastroCategoriaDTO();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM embalagem;", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosCategoria()
        {
            CadastroCategoriaDTO dto = new CadastroCategoriaDTO();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM categoria;", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosProduto()
        {

            CadastroProdutoDTO dto = new CadastroProdutoDTO();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT idProduto, Descricao, Nome, Categoria, Emb_compra, Fornecedor_idFornecedor, Categoria_idCategoria, Embalagem_idEmbalagem FROM Produto INNER JOIN Fornecedor ON Fornecedor.idFornecedor = Produto.Fornecedor_idFornecedor INNER JOIN Categoria ON Categoria.idCategoria = Produto.Categoria_idCategoria INNER JOIN Embalagem ON Embalagem.idEmbalagem = Produto.Embalagem_idEmbalagem; ", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosCotacao(CotacaoDTO dto)
        {

            try
            {

                DataTable DataT = new DataTable();


                MySqlCommand comando = new MySqlCommand("SELECT idProduto_Cotacao, Descricao, Emb_compra, Categoria FROM Produto_Cotacao INNER JOIN Produto ON Produto.idProduto = Produto_Cotacao.Produto_idProduto INNER JOIN Cotacao ON Cotacao.idCotacao = Produto_Cotacao.Cotacao_idCotacao  INNER JOIN Embalagem ON Embalagem.idEmbalagem = Produto_Cotacao.Embalagem_idEmbalagem  INNER JOIN Categoria ON Categoria.idCategoria = Produto_Cotacao.Categoria_idCategoria WHERE Cotacao_idCotacao = " + dto.Id + ";", conexao);

                da.SelectCommand = comando;

                da.Fill(DataT);

                return DataT;

            }


            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MaiorId(CotacaoDTO dto)
        {
            Cotação Cot = new Cotação();
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; User=root; database=Mercearia; password=;");
                conexao.Open();
                MySqlCommand selcon = new MySqlCommand("SELECT MAX(idCotacao) FROM cotacao;", conexao);
                MySqlDataReader rdr;
                rdr = selcon.ExecuteReader();
                rdr.Read();

                dto.Id = rdr.GetInt32(0);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao capturar id "+ex);
            }
        }

        public DataTable ExibirDadosCotacaoSalva()
        {

            try
            {

                DataTable DataT = new DataTable();


                MySqlCommand comando = new MySqlCommand("SELECT * FROM cotacao;", conexao);

                da.SelectCommand = comando;

                da.Fill(DataT);

                return DataT;

            }


            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
 

