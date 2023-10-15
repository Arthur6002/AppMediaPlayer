using AppMediaPlayer.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer.Pages
{
    public partial class Contas : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
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

        private void crownDockPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void pcbAdicionar_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Registro());
        }

        private void pnlAdicionar_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Registro());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormController.ShowForm(this, new Main());
        }
    }
}
