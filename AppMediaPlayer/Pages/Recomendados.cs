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
    public partial class Recomendados : Form
    {
        MusicController mc = new MusicController();

        public Recomendados()
        {
            InitializeComponent();
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            mc.Play("Imagine Dragons", "Natural", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Imagine%20Dragons%20%20Natural/Imagine%20Dragons%20%20Natural.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Imagine%20Dragons%20%20Natural/Imagine-Dragons-Natural.jpg");
        }

        private void hopePictureBox2_Click(object sender, EventArgs e)
        {
            mc.Play("Iron Maiden", "The Trooper", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Iron%20Maiden%20%20The%20Trooper/Iron%20Maiden%20%20The%20Trooper.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Iron%20Maiden%20%20The%20Trooper/Iron%20Maiden%20%20The%20Trooper.jpg");
        }

        private void hopePictureBox4_Click(object sender, EventArgs e)
        {
            mc.Play("Queen", "We Will Rock You", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Queen%20%20We%20Will%20Rock%20You/Queen%20%20We%20Will%20Rock%20You.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Queen%20%20We%20Will%20Rock%20You/Queen%20%20We%20Will%20Rock%20You.jpg");
        }

        private void hopePictureBox3_Click(object sender, EventArgs e)
        {
            mc.Play("Guns N Roses", "Sweet Child O Mine", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Guns%20N%20Roses%20%20Sweet%20Child%20O%20Mine/Guns%20N%20Roses%20%20Sweet%20Child%20O%20Mine.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Guns%20N%20Roses%20%20Sweet%20Child%20O%20Mine/Guns%20N%20Roses%20%20Sweet%20Child%20O%20Mine.jpeg");
        }

        private void hopePictureBox6_Click(object sender, EventArgs e)
        {
            mc.Play("Doom Eternal OST", "The Only Thing They Fear Is You", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You.jpg");
        }

        private void hopePictureBox5_Click(object sender, EventArgs e)
        {
            mc.Play("Michael Jackson", "Smooth Criminal", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Michael%20Jackson%20%20Smooth%20Criminal/Michael%20Jackson%20%20Smooth%20Criminal.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Michael%20Jackson%20%20Smooth%20Criminal/Michael%20Jackson%20%20Smooth%20Criminal.jpg");
        }
    }
}
