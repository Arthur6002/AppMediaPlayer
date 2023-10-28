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
    public partial class Inicio : Form
    {
        MusicController mc = new MusicController();
        public Inicio()
        {
            InitializeComponent();
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            mc.Play("Metalica", "Master of Puppets", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Metalica%20Master%20of%20Puppets/Metalica%20Master%20of%20Puppets.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Metalica%20Master%20of%20Puppets/Metalica%20Master%20of%20Puppets.jpg");
        }

        private void hopePictureBox2_Click(object sender, EventArgs e)
        {
            mc.Play("Maroon 5", "Sugar", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Maroon%205%20%20Sugar/Maroon%205%20%20Sugar.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Maroon%205%20%20Sugar/Maroon%205%20%20Sugar.jpg");
        }

        private void hopePictureBox12_Click(object sender, EventArgs e)
        {
            mc.Play("The Weeknd", "Starboy", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/The%20Weeknd%20%20Starboy/The%20Weeknd%20%20Starboy.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/The%20Weeknd%20%20Starboy/The%20Weeknd%20%20Starboy.jpg");
        }

        private void hopePictureBox3_Click(object sender, EventArgs e)
        { 
            mc.Play("Michael Jackson", "Smooth Criminal", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Michael%20Jackson%20%20Smooth%20Criminal/Michael%20Jackson%20%20Smooth%20Criminal.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Michael%20Jackson%20%20Smooth%20Criminal/Michael%20Jackson%20%20Smooth%20Criminal.jpg");
        }

        private void hopePictureBox4_Click(object sender, EventArgs e)
        {
            mc.Play("Kiss", "I Was Made For Lovin You", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Kiss%20%20I%20Was%20Made%20For%20Lovin%20You/Kiss%20%20I%20Was%20Made%20For%20Lovin%20You.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Kiss%20%20I%20Was%20Made%20For%20Lovin%20You/Kiss%20%20I%20Was%20Made%20For%20Lovin%20You.jpg");
        }

        private void hopePictureBox5_Click(object sender, EventArgs e)
        {
            mc.Play("Nirvana", "Smells Like Teen Spirit", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Nirvana%20%20Smells%20Like%20Teen%20Spirit/Nirvana%20%20Smells%20Like%20Teen%20Spirit.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Nirvana%20%20Smells%20Like%20Teen%20Spirit/Nirvana%20%20Smells%20Like%20Teen%20Spirit.jpg");
        }

        private void hopePictureBox6_Click(object sender, EventArgs e)
        {
            mc.Play("BLACK SABBATH", "Paranoid", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/BLACK%20SABBATH%20%20Paranoid/BLACK%20SABBATH%20%20Paranoid.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/BLACK%20SABBATH%20%20Paranoid/BLACK%20SABBATH%20%20Paranoid.jpg");
        }

        private void hopePictureBox7_Click(object sender, EventArgs e)
        {
            mc.Play("Metal Gear Rising", "The Only Thing I Know For Real", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Metal%20Gear%20Rising%20The%20Only%20Thing%20I%20Know%20For%20Real/Metal%20Gear%20Rising%20The%20Only%20Thing%20I%20Know%20For%20Real.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Rock/Metal%20Gear%20Rising%20The%20Only%20Thing%20I%20Know%20For%20Real/Metal%20Gear%20Rising%20The%20Only%20Thing%20I%20Know%20For%20Real.jpg");
        }

        private void hopePictureBox11_Click(object sender, EventArgs e)
        {
            mc.Play("Katy Perry", "Roar", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Katy%20Perry%20%20Roar/Katy%20Perry%20%20Roar.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Katy%20Perry%20%20Roar/Katy%20Perry%20%20Roar.jpg");
        }

        private void hopePictureBox10_Click(object sender, EventArgs e)
        {
            mc.Play("Harry Styles", "Sign of the Times", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Harry%20Styles%20%20Sign%20of%20the%20Times/Harry%20Styles%20%20Sign%20of%20the%20Times.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Harry%20Styles%20%20Sign%20of%20the%20Times/Harry%20Styles%20%20Sign%20of%20the%20Times.jpg");
        }

        private void hopePictureBox9_Click(object sender, EventArgs e)
        {
            mc.Play("7 rings", "Ariana Grande", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Ariana%20Grande%20%207%20rings/Ariana%20Grande%20%207%20rings.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/Ariana%20Grande%20%207%20rings/Ariana%20Grande%20%207%20rings.jpg");
        }

        private void hopePictureBox8_Click(object sender, EventArgs e)
        {
            mc.Play("twenty one pilots", "Stressed Out", "", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/twenty%20one%20pilots%20Stressed%20Out/twenty%20one%20pilots%20Stressed%20Out.mp3", "http://nebula.iagofragnan.com.br/arthurcf/expotec/musicas/Pop/twenty%20one%20pilots%20Stressed%20Out/twenty%20one%20pilots%20Stressed%20Out.jpg");
        }
    }
}
