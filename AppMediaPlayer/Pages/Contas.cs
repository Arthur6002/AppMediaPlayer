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
    public partial class Contas : Form
    {
        public Contas()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void pnl_add_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Login());
        }

        private void pb_add_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Login());
        }

        private void pcbAdicionar_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Registro());
        }

        private void pnlAdicionar_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Registro());
        }
    }
}
