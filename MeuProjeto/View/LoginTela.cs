using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuProjeto.View
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {

            string usuario = txbuser.Text;
            string senha = txbsenha.Text;

            //O algoritimo para verificar as credenciais e permitir o acesso
            if (usuario == "admin" && senha == "123")
            {
                //Vai fechar a tela de login e abrir a tela do menu
                this.Hide(); //this -> este hide ->esconde/oculta
                //Instanciar a tela do menu
                MenuTela Menu = new MenuTela();
                //A tela menu ira fechar, junto com toda a aplicação
                //Porém irá abrir a tela menu novamente
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();

            }
            else
            {
                MessageBox.Show("Senha Ou Usuário incorreto");
                txbuser.Text = "";
                txbsenha.Text = "";
            }

        }

        private void txb_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}

