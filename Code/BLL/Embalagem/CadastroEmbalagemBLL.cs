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
    class CadastroEmbalagemBLL
    {
        conexaoBD bd = new conexaoBD();

        public void InserirEmbalagem(CadastroEmbalagemDTO dto)
        {
            try
            {
             bd.Conectar();

             string comando  = "INSERT INTO embalagem(Emb_compra) VALUES ('" + dto.Embalagem +"')";
             bd.ExecutarComandoSQL(comando);

             MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar" + ex.Message);

            }

        }

    }
}
