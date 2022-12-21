using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using System.Data;
using System.Data.SqlClient;


namespace SistemPlus.Code.BLL
{
    class PesquisaBLL
    {
        conexaoBD bd = null;

        public DataTable ExibirDadosFornecedorDAL()
        {
            try
            {
                DataTable DataT = new DataTable();
                bd = new conexaoBD();

                DataT = bd.ExibirDadosFornecedor();

                return DataT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable PesquisarFornecedorDAL()
        {
            try
            {
                DataTable DataT = new DataTable();
                bd = new conexaoBD();

                DataT = bd.PesquisaFornecedor();

                return DataT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosEmbalagemDAL()
        {
            try
            {
                DataTable DataT = new DataTable();
                bd = new conexaoBD();

                DataT = bd.ExibirDadosEmbalagens();

                return DataT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosCategoriaDAL()
        {
            try
            {
                DataTable DataT = new DataTable();
                bd = new conexaoBD();

                DataT = bd.ExibirDadosCategoria();

                return DataT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirDadosProdutoDAL()
        {
            try
            {
                DataTable DataT = new DataTable();
                bd = new conexaoBD();

                DataT = bd.ExibirDadosProduto();

                return DataT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

