using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemPlus.Code.BLL.Cotacao
{


    class CadastroProdutoCotacaoBLL
    {
        conexaoBD bd = new conexaoBD();

        public void InserirProdutoCotacao(CadastroProdutoCotacaoDTO dto)
        {
            try
            {
                bd.Conectar();
                string comando = "INSERT INTO Produto_Cotacao (Produto_idProduto, Cotacao_idCotacao, Categoria_idCategoria, Embalagem_idEmbalagem ) VALUES ('" + dto.Produto_idproduto + "','" + dto.Cotacao_idcotacao + "','" + dto.Categoria_idcategoria + "','" + dto.Embalagem_idembalagem + "')";
                bd.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro no programa" + ex.Message);
            }

        }


       
 
    }
}
