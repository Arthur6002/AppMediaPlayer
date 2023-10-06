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
            Environment.Exit(0);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextButton == "usuario" && txtSenha.TextButton == "abc")
            {
                Form logado = new Form1();
                logado.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorretos");
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

        private void txtSenha_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
