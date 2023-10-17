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
    public partial class Musicas : Form
    {
        MusicController mc = new MusicController();
        public Musicas()
        {
            InitializeComponent();
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            mc.Play("Feel GOOD INC","Gorillaz","Demon Days", "http://api.iagofragnan.com.br/rbox/gorillaz/gorillaz_phsong.mp3", "http://api.iagofragnan.com.br/rbox/gorillaz/Demon_Days.jpg");
        }

        private void hopePictureBox2_Click(object sender, EventArgs e)
        {
            mc.Play("Diamantes e Peixes", "Yung Lixo", "Cybertapes", "http://api.iagofragnan.com.br/rbox/diamantes_e_peixes/diamantesepeixes.mp3", "http://api.iagofragnan.com.br/rbox/diamantes_e_peixes/diamantes.png");
        }
    }
}
