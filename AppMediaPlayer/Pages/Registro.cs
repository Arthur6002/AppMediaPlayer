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
            txtSenha.Password = rdbMostrarSenha.Checked;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Contas());
        }

        private void foxLinkLabel1_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Login());
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            ManageUser.criarUsuario(txtUsuario.TextButton, txtSenha.TextButton, txtEmail.TextButton);
            FormController.ShowForm(this, new Login());
        }
    }
}
