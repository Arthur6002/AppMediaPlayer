using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer
{
    public partial class Form1 : Form
    {
        bool Play = true;
        public Form1()
        {
            InitializeComponent();
            //scroll musicas
            scrRolagemMusicas.Value = flpMusicas.VerticalScroll.Value;
            scrRolagemMusicas.Maximum = flpMusicas.VerticalScroll.Maximum;
            scrRolagemMusicas.Minimum = flpMusicas.VerticalScroll.Minimum;

            //scroll playlists
            scrPlaylists.Value = flpPlaylists.VerticalScroll.Value;
            scrPlaylists.Maximum = flpPlaylists.VerticalScroll.Maximum;
            scrPlaylists.Minimum = flpPlaylists.VerticalScroll.Minimum;
        }


        //Botão musicas
        private void lblMusicas_Click(object sender, EventArgs e)
        {
            
        }
        private void lblMusicas_MouseEnter(object sender, EventArgs e)
        {
            lblMusicas.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblMusicas_MouseLeave(object sender, EventArgs e)
        {
            lblMusicas.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

        //Botão PlayLists
        private void lblPlayList_Click(object sender, EventArgs e)
        {

        }
        private void lblPlayList_MouseEnter(object sender, EventArgs e)
        {
            lblPlayList.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblPlayList_MouseLeave(object sender, EventArgs e)
        {
            lblPlayList.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

        //Botão Recomendados
        private void lblRecomendados_Click(object sender, EventArgs e)
        {

        }
        private void lblRecomendados_MouseEnter(object sender, EventArgs e)
        {
            lblRecomendados.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblRecomendados_MouseLeave(object sender, EventArgs e)
        {
            lblRecomendados.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

        //Botão Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(Play)
            {
                btnPlay.Image = Properties.Resources.Pause;
                Play = false;
            }
            else
            {
                btnPlay.Image = Properties.Resources.Play;
                Play = true;
            }
        }

        private void scrRolagemMusicas_Scroll(object sender, ScrollEventArgs e)
        {
            flpMusicas.VerticalScroll.Value = scrRolagemMusicas.Value;
        }

        private void scrPlaylists_Scroll(object sender, ScrollEventArgs e)
        {
            flpPlaylists.VerticalScroll.Value = scrPlaylists.Value;
        }
    }
}
