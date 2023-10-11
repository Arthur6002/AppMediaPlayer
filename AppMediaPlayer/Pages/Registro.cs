using AppMediaPlayer.Controller;
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
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void foxLinkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logado = new Login();
            logado.ShowDialog();
        }

        private async void btnRegistro_Click_1(object sender, EventArgs e)
        {
            ManageUser.criarUsuario(txtUsuario.TextButton, txtSenha.TextButton, txtEmail.TextButton);
            this.Hide();
            Form login = new Login();
            login.ShowDialog();
        }
    }
}
