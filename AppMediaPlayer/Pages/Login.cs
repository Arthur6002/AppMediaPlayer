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
            FormController.ShowForm(this, new Contas());
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            ManageUser mg = new ManageUser();
            List<Usuario> Usuarios = mg.GetUsuarios();

            foreach (var teste in Usuarios)
            {
                if (teste.nome == txtUsuario.TextButton && teste.senha == txtSenha.TextButton)
                {
                    mg.setUser(teste.nome);
                    FormController.ShowForm(this, new Main());
                    return;
                }
            }
            MessageBox.Show("Usuario ou Senha incorreto(s)", "Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void rdbMostrarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Password = rdbMostrarSenha.Checked;
        }

        
        private void foxLinkLabel1_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Registro());
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Contas());
        }
    }
}
