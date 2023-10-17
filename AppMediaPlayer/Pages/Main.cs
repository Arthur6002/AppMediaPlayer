using AppMediaPlayer.Controller;
using AppMediaPlayer.Model;
using AppMediaPlayer.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer
{
    public partial class Main : Form
    {

        bool Play = true;

        MusicController Music_Con = new MusicController();

        public Main()
        {
            InitializeComponent();
            Form inicio = new Inicio();
            Change_Form(pnlMain, inicio);

            ManageUser uc = new ManageUser();
            List<Usuario> uc2 = uc.GetLogged();
            foreach (var v in uc2)
            {
                lbl_UserName.Text = v.nome;
            }
        }
        void Change_Form(Panel painel, Form form)
        {
            painel.Controls.Clear();
            form.TopLevel = false;
            painel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();
        }
        //Botão musicas
        private void lblMusicas_Click(object sender, EventArgs e)
        {
            Form musicas = new Pages.Musicas();
            Change_Form(pnlMain, musicas);
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
            Form playlist = new Pages.Playlists();
            Change_Form(pnlMain, playlist);
        }
        private void lblPlayList_MouseEnter(object sender, EventArgs e)
        {
            lblPlayList.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblPlayList_MouseLeave(object sender, EventArgs e)
        {
            lblPlayList.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }
        private void lblRecomendados_MouseEnter(object sender, EventArgs e)
        {
            lblInicio.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblRecomendados_MouseLeave(object sender, EventArgs e)
        {
            lblInicio.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

        //Botão Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!Song.Playing && Song.Name == null || Song.Name == " " && Song.Artist == null)
                return;

            if (!Song.Playing)
            {
                Music_Con.Resume();
                btnPlay.Image = Properties.Resources.Pause;
                Song.Playing = true;
            }
            else
            {
                Music_Con.Pause();
                btnPlay.Image = Properties.Resources.Play;
                Song.Playing = false;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair da sua conta e voltar à tela inicial?", "Retorno à Tela Inicial", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                FormController.ShowForm(this, new Contas());
            return;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Main_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Song_Refresher_Tick(object sender, EventArgs e)
        {

            if (!Song.Playing)
            {
                if (Song.Name != null || Song.Name != " ")
                    return;

                btnPlay.Image = Properties.Resources.Play;
                pbox_cover.Image = Properties.Resources.ph;

                lbl_song_name.Visible = false;
                lbl_song_author.Visible = false;
                lbl_song_album.Visible = false;
                pbox_cover.Visible = false;

                Play = false;

            }
            else
            {
                btnPlay.Image = Properties.Resources.Pause;

                lbl_song_name.Text = Song.Name;
                lbl_song_author.Text = Song.Artist;
                lbl_song_album.Text = Song.Album;
                pbox_cover.Load(Song.Cover);

                lbl_song_name.Visible = true;
                pbox_cover.Visible = true;
                lbl_song_author.Visible = true;
                lbl_song_album.Visible = true;

                Play = true;

            }
            Console.WriteLine("Tocando? " + Song.Playing);

        }

        private void sldrVolume_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form creditos = new Creditos();
            Change_Form(pnlMain, creditos);

        }

        private void lblMusicas_MouseHover(object sender, EventArgs e)
        {   
            Cursor.Current = Cursors.Default;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, FontStyle.Underline);

        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, FontStyle.Regular);

        }
<<<<<<< HEAD

        private void lblInicio_Click(object sender, EventArgs e)
        {
            Form inicio = new Pages.Inicio();
            Change_Form(pnlMain, inicio);
        }
=======
>>>>>>> baa08e54af6d07656c2d0156ecfe14c0825dc408
    }
}
