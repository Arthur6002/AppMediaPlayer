namespace AppMediaPlayer
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblRecomendados = new System.Windows.Forms.Label();
            this.lblMusicas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Song_Refresher = new System.Windows.Forms.Timer(this.components);
            this.slider_song = new ReaLTaiizor.Controls.ParrotSlider();
            this.lbl_song_author = new System.Windows.Forms.Label();
            this.lbl_song_name = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_song_album = new System.Windows.Forms.Label();
            this.pbox_cover = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.slider_volume = new ReaLTaiizor.Controls.MaterialSlider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.lblRecomendados);
            this.panel1.Controls.Add(this.lblMusicas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 765);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppMediaPlayer.Properties.Resources.star;
            this.pictureBox4.Location = new System.Drawing.Point(49, 596);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Créditos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(26, 134);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(60, 24);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            this.lblInicio.MouseEnter += new System.EventHandler(this.lblRecomendados_MouseEnter);
            this.lblInicio.MouseLeave += new System.EventHandler(this.lblRecomendados_MouseLeave);
            // 
            // lblRecomendados
            // 
            this.lblRecomendados.AutoSize = true;
            this.lblRecomendados.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendados.ForeColor = System.Drawing.Color.White;
            this.lblRecomendados.Location = new System.Drawing.Point(23, 322);
            this.lblRecomendados.Name = "lblRecomendados";
            this.lblRecomendados.Size = new System.Drawing.Size(156, 24);
            this.lblRecomendados.TabIndex = 6;
            this.lblRecomendados.Text = "Recomendadas";
            this.lblRecomendados.Click += new System.EventHandler(this.lblPlayList_Click);
            this.lblRecomendados.MouseEnter += new System.EventHandler(this.lblPlayList_MouseEnter);
            this.lblRecomendados.MouseLeave += new System.EventHandler(this.lblPlayList_MouseLeave);
            // 
            // lblMusicas
            // 
            this.lblMusicas.AutoSize = true;
            this.lblMusicas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicas.ForeColor = System.Drawing.Color.White;
            this.lblMusicas.Location = new System.Drawing.Point(23, 226);
            this.lblMusicas.Name = "lblMusicas";
            this.lblMusicas.Size = new System.Drawing.Size(88, 24);
            this.lblMusicas.TabIndex = 4;
            this.lblMusicas.Text = "Musicas";
            this.lblMusicas.Click += new System.EventHandler(this.lblMusicas_Click);
            this.lblMusicas.MouseEnter += new System.EventHandler(this.lblMusicas_MouseEnter);
            this.lblMusicas.MouseLeave += new System.EventHandler(this.lblMusicas_MouseLeave);
            this.lblMusicas.MouseHover += new System.EventHandler(this.lblMusicas_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_UserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 100);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(116, 24);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(68, 23);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Usuario";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pnlMain.Location = new System.Drawing.Point(226, 99);
            this.pnlMain.MinimumSize = new System.Drawing.Size(261, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1046, 544);
            this.pnlMain.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(674, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(156, 34);
            this.txtTitulo.TabIndex = 28;
            this.txtTitulo.Text = "RythmBox";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1214, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Song_Refresher
            // 
            this.Song_Refresher.Enabled = true;
            this.Song_Refresher.Interval = 50;
            this.Song_Refresher.Tick += new System.EventHandler(this.Song_Refresher_Tick);
            // 
            // slider_song
            // 
            this.slider_song.BarThickness = 10;
            this.slider_song.BigStepIncrement = 10;
            this.slider_song.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("slider_song.Colors")));
            this.slider_song.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.slider_song.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slider_song.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.slider_song.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.slider_song.KnobColor = System.Drawing.Color.Gray;
            this.slider_song.KnobImage = null;
            this.slider_song.Location = new System.Drawing.Point(429, 82);
            this.slider_song.Max = 100;
            this.slider_song.Name = "slider_song";
            this.slider_song.Percentage = 0;
            this.slider_song.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.slider_song.Positions = ((System.Collections.Generic.List<float>)(resources.GetObject("slider_song.Positions")));
            this.slider_song.QuickHopping = false;
            this.slider_song.Size = new System.Drawing.Size(548, 20);
            this.slider_song.SliderStyle = ReaLTaiizor.Controls.ParrotSlider.Style.Windows10;
            this.slider_song.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.slider_song.TabIndex = 5;
            this.slider_song.Text = "parrotSlider1";
            this.slider_song.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // lbl_song_author
            // 
            this.lbl_song_author.AutoSize = true;
            this.lbl_song_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_song_author.ForeColor = System.Drawing.Color.Black;
            this.lbl_song_author.Location = new System.Drawing.Point(130, 96);
            this.lbl_song_author.Name = "lbl_song_author";
            this.lbl_song_author.Size = new System.Drawing.Size(72, 13);
            this.lbl_song_author.TabIndex = 9;
            this.lbl_song_author.Text = "Not Playing";
            this.lbl_song_author.Visible = false;
            // 
            // lbl_song_name
            // 
            this.lbl_song_name.AutoSize = true;
            this.lbl_song_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_song_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_song_name.Location = new System.Drawing.Point(130, 82);
            this.lbl_song_name.Name = "lbl_song_name";
            this.lbl_song_name.Size = new System.Drawing.Size(72, 13);
            this.lbl_song_name.TabIndex = 11;
            this.lbl_song_name.Text = "Not Playing";
            this.lbl_song_name.Visible = false;
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.Purple;
            this.pnlControles.Controls.Add(this.pictureBox3);
            this.pnlControles.Controls.Add(this.slider_volume);
            this.pnlControles.Controls.Add(this.lbl_song_name);
            this.pnlControles.Controls.Add(this.lbl_song_album);
            this.pnlControles.Controls.Add(this.lbl_song_author);
            this.pnlControles.Controls.Add(this.pbox_cover);
            this.pnlControles.Controls.Add(this.slider_song);
            this.pnlControles.Controls.Add(this.btnPlay);
            this.pnlControles.Location = new System.Drawing.Point(3, 641);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(1269, 124);
            this.pnlControles.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::AppMediaPlayer.Properties.Resources.volume;
            this.pictureBox3.Location = new System.Drawing.Point(984, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_song_album
            // 
            this.lbl_song_album.AutoSize = true;
            this.lbl_song_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_song_album.ForeColor = System.Drawing.Color.Pink;
            this.lbl_song_album.Location = new System.Drawing.Point(130, 69);
            this.lbl_song_album.Name = "lbl_song_album";
            this.lbl_song_album.Size = new System.Drawing.Size(72, 13);
            this.lbl_song_album.TabIndex = 10;
            this.lbl_song_album.Text = "Not Playing";
            this.lbl_song_album.Visible = false;
            // 
            // pbox_cover
            // 
            this.pbox_cover.Image = global::AppMediaPlayer.Properties.Resources.ph;
            this.pbox_cover.Location = new System.Drawing.Point(24, 13);
            this.pbox_cover.Name = "pbox_cover";
            this.pbox_cover.Size = new System.Drawing.Size(102, 99);
            this.pbox_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_cover.TabIndex = 8;
            this.pbox_cover.TabStop = false;
            this.pbox_cover.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.Image = global::AppMediaPlayer.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(677, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 55);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 2;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBox2.Image = global::AppMediaPlayer.Properties.Resources.logo_improved;
            this.pictureBox2.Location = new System.Drawing.Point(600, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // slider_volume
            // 
            this.slider_volume.Depth = 0;
            this.slider_volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slider_volume.Location = new System.Drawing.Point(1020, 31);
            this.slider_volume.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.slider_volume.Name = "slider_volume";
            this.slider_volume.Size = new System.Drawing.Size(217, 40);
            this.slider_volume.TabIndex = 13;
            this.slider_volume.Text = "";
            this.slider_volume.Value = 100;
            this.slider_volume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_volume_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1272, 765);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lblMusicas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblRecomendados;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer Song_Refresher;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnPlay;
        private ReaLTaiizor.Controls.ParrotSlider slider_song;
        private System.Windows.Forms.PictureBox pbox_cover;
        private System.Windows.Forms.Label lbl_song_author;
        private System.Windows.Forms.Label lbl_song_name;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_song_album;
        private ReaLTaiizor.Controls.MaterialSlider slider_volume;
    }
}

