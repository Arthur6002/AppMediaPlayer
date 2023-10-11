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
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logado = new Registro();
            logado.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Form logado = new Registro();
            logado.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logado = new Form1();
            logado.ShowDialog();
        }
    }
}
