using AppMediaPlayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }

        public bool verifyCon()
        {
            Ping ping = new Ping();

            PingReply pingStatus = ping.Send(IPAddress.Parse("8.8.4.4"));

            if (pingStatus.Status == IPStatus.Success)
                return true;
           
            return false;
        }

        private void loader_Load(object sender, EventArgs e)
        {
            this.Hide();

            //if(!verifyCon())
            //{
            //    MessageBox.Show("Error 504 | Gateway Timeout");
            //    Environment.Exit(0);
            //}

            Song.Playing = false;


            Form contas = new AppMediaPlayer.Pages.Contas();
            contas.Show();
        }
    }
}
