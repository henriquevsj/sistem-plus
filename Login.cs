using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemPlus.Code.DTO;
using SistemPlus.Code.BLL.Login;

namespace SistemPlus
{
    public partial class Login : Form
    {
        CadastroEmbalagemDTO DTOemb = new CadastroEmbalagemDTO();
         LoginBLL BLLLogin = new LoginBLL();
        LoginDTO DTOlogin = new LoginDTO();

        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogar_Click(object sender, EventArgs e)
        {

        }
        private bool ValidaLogin(object sender, EventArgs e)
        {
            try
            {
                DTOlogin.User = TextBoxUser.ToString();
                DTOlogin.Senha = TextBoxUser.ToString();

                BLLLogin.ValidaLogin(DTOlogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados incorretos, tente novamente" + ex);
            }
            return true;
        }
    }
}
