using AppMediaPlayer.Controller;
using AppMediaPlayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer.Pages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ManageUser mg = new ManageUser();
            List<Usuario> Usuarios = mg.GetUsuarios();

            foreach (var teste in Usuarios)
            {
                if (teste.nome == txtUsuario.TextButton && teste.senha == txtSenha.TextButton)
                {
                    this.Hide();
                    Form logado = new Form1();
                    logado.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha incorretos");
                }
            }

        }

        private void rdbMostrarSenha_Click(object sender, EventArgs e)
        {
            if (rdbMostrarSenha.Checked)
            {
                txtSenha.Password = true;
            }
            else
            {
                txtSenha.Password = false;
            }
        }
        private void foxLinkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logado = new Registro();
            logado.ShowDialog();
        }
    }
}
