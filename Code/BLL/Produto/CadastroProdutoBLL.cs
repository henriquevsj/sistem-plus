using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemPlus.Code.DTO;
using SistemPlus.Code.DAL;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL
{
    
    class CadastroProdutoBLL
    {
        conexaoBD bd = new conexaoBD(); 
        
        public void Inserir(CadastroProdutoDTO dto)
        {

            try
            {

                bd.Conectar();
                string comando = "INSERT INTO Produto(Descricao, Fornecedor_idFornecedor, Categoria_idCategoria, Embalagem_idEmbalagem) VALUES ('" + dto.Descricao + "','" + dto.Fornecedor_idFornecedor + "','" + dto.Categoria_idCategoria + "','" + dto.Embalagem_idEmbalagem + "')";
                bd.ExecutarComandoSQL(comando);
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
