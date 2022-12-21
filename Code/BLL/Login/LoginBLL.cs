using SistemPlus.Code.DAL;
using SistemPlus.Code.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPlus.Code.BLL.Login
{
    class LoginBLL
    {
        conexaoBD bd = new conexaoBD();
        DataTable dataTable = new DataTable();
        MySqlDataAdapter dados = new MySqlDataAdapter();
        LoginDTO teste = new LoginDTO();

        public void ValidaLogin(LoginDTO dto)
        {
            try
            {
                bd.Conectar();

                string comando = "SELECT * FROM  Usuario";
                bd.ExecutarComandoSQL(comando);
                dados.Fill(dataTable);

               var nomeUsuarioCadastrado = dataTable.Rows[1]["Nome"];
                var senhaUsuarioCadastrado = dataTable.Rows[1]["Senha"];
                if (dto.User != nomeUsuarioCadastrado.ToString())
                    throw new Exception("");
                if (dto.Senha != senhaUsuarioCadastrado.ToString())
                    throw new Exception("");
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar" + ex.Message);

            }

        }
    }
}

