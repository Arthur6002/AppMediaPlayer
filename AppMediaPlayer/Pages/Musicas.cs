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
            mc.Play("Arctic Monkeys", "Do I Wanna Know", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Arctic%20Monkeys%20%20Do%20I%20Wanna%20Know/Arctic%20Monkeys%20%20Do%20I%20Wanna%20Know.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Arctic%20Monkeys%20%20Do%20I%20Wanna%20Know/Arctic%20Monkeys%20%20Do%20I%20Wanna%20Know.jpg");
        }

        private void hopePictureBox2_Click(object sender, EventArgs e)
        {
            mc.Play("7 rings", "Ariana Grande", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Ariana%20Grande%20%207%20rings/Ariana%20Grande%20%207%20rings.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Ariana%20Grande%20%207%20rings/Ariana%20Grande%20%207%20rings.jpg");
        }

        private void hopePictureBox4_Click(object sender, EventArgs e)
        {
            mc.Play("The Lazy Song", "Bruno Mars", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Bruno%20Mars%20%20The%20Lazy%20Song/Bruno%20Mars%20%20The%20Lazy%20Song.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Bruno%20Mars%20%20The%20Lazy%20Song/Bruno%20Mars%20%20The%20Lazy%20Song.jpg");
        }

        private void hopePictureBox3_Click(object sender, EventArgs e)
        {
            mc.Play("The Only Thing They Fear Is You", "Doom Eternal OST", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You/Doom%20Eternal%20OST%20%20The%20Only%20Thing%20They%20Fear%20Is%20You.jpg");
        }

        private void hopePictureBox6_Click(object sender, EventArgs e)
        {
            mc.Play("Higway to Hell", "AC/DC", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Higway%20to%20Hell/ACDC%20Highway%20to%20Hell.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Higway%20to%20Hell/Higway%20to%20Hell.jpg");
        }

        private void hopePictureBox5_Click(object sender, EventArgs e)
        {
            mc.Play("Queen", "We Will Rock You", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Queen%20%20We%20Will%20Rock%20You/Queen%20%20We%20Will%20Rock%20You.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Queen%20%20We%20Will%20Rock%20You/Queen%20%20We%20Will%20Rock%20You.jpg");
        }
    }
}
