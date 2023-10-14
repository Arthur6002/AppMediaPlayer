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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecomendados = new System.Windows.Forms.Label();
            this.lblPlayList = new System.Windows.Forms.Label();
            this.lblMusicas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.parrotSlider1 = new ReaLTaiizor.Controls.ParrotSlider();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sldrVolume = new ReaLTaiizor.Controls.ParrotSlider();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_song_author = new System.Windows.Forms.Label();
            this.lbl_song_album = new System.Windows.Forms.Label();
            this.lbl_song_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblRecomendados);
            this.panel1.Controls.Add(this.lblPlayList);
            this.panel1.Controls.Add(this.lblMusicas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 765);
            this.panel1.TabIndex = 0;
            // 
            // lblRecomendados
            // 
            this.lblRecomendados.AutoSize = true;
            this.lblRecomendados.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendados.ForeColor = System.Drawing.Color.White;
            this.lblRecomendados.Location = new System.Drawing.Point(23, 233);
            this.lblRecomendados.Name = "lblRecomendados";
            this.lblRecomendados.Size = new System.Drawing.Size(156, 24);
            this.lblRecomendados.TabIndex = 7;
            this.lblRecomendados.Text = "Recomendados";
            this.lblRecomendados.MouseEnter += new System.EventHandler(this.lblRecomendados_MouseEnter);
            this.lblRecomendados.MouseLeave += new System.EventHandler(this.lblRecomendados_MouseLeave);
            // 
            // lblPlayList
            // 
            this.lblPlayList.AutoSize = true;
            this.lblPlayList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayList.ForeColor = System.Drawing.Color.White;
            this.lblPlayList.Location = new System.Drawing.Point(23, 322);
            this.lblPlayList.Name = "lblPlayList";
            this.lblPlayList.Size = new System.Drawing.Size(88, 24);
            this.lblPlayList.TabIndex = 6;
            this.lblPlayList.Text = "Playlists";
            this.lblPlayList.Click += new System.EventHandler(this.lblPlayList_Click);
            this.lblPlayList.MouseEnter += new System.EventHandler(this.lblPlayList_MouseEnter);
            this.lblPlayList.MouseLeave += new System.EventHandler(this.lblPlayList_MouseLeave);
            // 
            // lblMusicas
            // 
            this.lblMusicas.AutoSize = true;
            this.lblMusicas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicas.ForeColor = System.Drawing.Color.White;
            this.lblMusicas.Location = new System.Drawing.Point(23, 139);
            this.lblMusicas.Name = "lblMusicas";
            this.lblMusicas.Size = new System.Drawing.Size(88, 24);
            this.lblMusicas.TabIndex = 4;
            this.lblMusicas.Text = "Musicas";
            this.lblMusicas.Click += new System.EventHandler(this.lblMusicas_Click);
            this.lblMusicas.MouseEnter += new System.EventHandler(this.lblMusicas_MouseEnter);
            this.lblMusicas.MouseLeave += new System.EventHandler(this.lblMusicas_MouseLeave);
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
            this.pictureBox1.Location = new System.Drawing.Point(43, 11);
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
            this.lbl_UserName.Location = new System.Drawing.Point(116, 20);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(68, 23);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Usuario";
            this.lbl_UserName.Click += new System.EventHandler(this.lbl_UserName_Click);
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.Pink;
            this.pnlControles.Controls.Add(this.lbl_song_name);
            this.pnlControles.Controls.Add(this.lbl_song_album);
            this.pnlControles.Controls.Add(this.lbl_song_author);
            this.pnlControles.Controls.Add(this.pictureBox4);
            this.pnlControles.Controls.Add(this.sldrVolume);
            this.pnlControles.Controls.Add(this.pictureBox3);
            this.pnlControles.Controls.Add(this.parrotSlider1);
            this.pnlControles.Controls.Add(this.btnForward);
            this.pnlControles.Controls.Add(this.btnBack);
            this.pnlControles.Controls.Add(this.btnPlay);
            this.pnlControles.Location = new System.Drawing.Point(3, 641);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(1269, 124);
            this.pnlControles.TabIndex = 1;
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Green;
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
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 20.25F);
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(674, 32);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(138, 32);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBox2.Image = global::AppMediaPlayer.Properties.Resources.PlayButton;
            this.pictureBox2.Location = new System.Drawing.Point(600, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Image = global::AppMediaPlayer.Properties.Resources.Play;
            this.btnBack.Location = new System.Drawing.Point(620, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 55);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForward.Image = global::AppMediaPlayer.Properties.Resources.Play;
            this.btnForward.Location = new System.Drawing.Point(734, 21);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(51, 55);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnForward.TabIndex = 4;
            this.btnForward.TabStop = false;
            // 
            // parrotSlider1
            // 
            this.parrotSlider1.BarThickness = 4;
            this.parrotSlider1.BigStepIncrement = 10;
            this.parrotSlider1.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("parrotSlider1.Colors")));
            this.parrotSlider1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotSlider1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.parrotSlider1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotSlider1.KnobColor = System.Drawing.Color.Gray;
            this.parrotSlider1.KnobImage = null;
            this.parrotSlider1.Location = new System.Drawing.Point(429, 82);
            this.parrotSlider1.Max = 100;
            this.parrotSlider1.Name = "parrotSlider1";
            this.parrotSlider1.Percentage = 0;
            this.parrotSlider1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotSlider1.Positions = ((System.Collections.Generic.List<float>)(resources.GetObject("parrotSlider1.Positions")));
            this.parrotSlider1.QuickHopping = false;
            this.parrotSlider1.Size = new System.Drawing.Size(548, 20);
            this.parrotSlider1.SliderStyle = ReaLTaiizor.Controls.ParrotSlider.Style.Windows10;
            this.parrotSlider1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotSlider1.TabIndex = 5;
            this.parrotSlider1.Text = "parrotSlider1";
            this.parrotSlider1.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::AppMediaPlayer.Properties.Resources.Play;
            this.pictureBox3.Location = new System.Drawing.Point(1078, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // sldrVolume
            // 
            this.sldrVolume.BarThickness = 4;
            this.sldrVolume.BigStepIncrement = 10;
            this.sldrVolume.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("sldrVolume.Colors")));
            this.sldrVolume.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.sldrVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sldrVolume.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.sldrVolume.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.sldrVolume.KnobColor = System.Drawing.Color.Gray;
            this.sldrVolume.KnobImage = null;
            this.sldrVolume.Location = new System.Drawing.Point(1128, 56);
            this.sldrVolume.Max = 100;
            this.sldrVolume.Name = "sldrVolume";
            this.sldrVolume.Percentage = 0;
            this.sldrVolume.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.sldrVolume.Positions = ((System.Collections.Generic.List<float>)(resources.GetObject("sldrVolume.Positions")));
            this.sldrVolume.QuickHopping = false;
            this.sldrVolume.Size = new System.Drawing.Size(117, 20);
            this.sldrVolume.SliderStyle = ReaLTaiizor.Controls.ParrotSlider.Style.Windows10;
            this.sldrVolume.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.sldrVolume.TabIndex = 7;
            this.sldrVolume.Text = "parrotSlider2";
            this.sldrVolume.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppMediaPlayer.Properties.Resources._71M8yXz6o7L__UF1000_1000_QL80_;
            this.pictureBox4.Location = new System.Drawing.Point(24, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 99);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_song_author
            // 
            this.lbl_song_author.AutoSize = true;
            this.lbl_song_author.Location = new System.Drawing.Point(130, 96);
            this.lbl_song_author.Name = "lbl_song_author";
            this.lbl_song_author.Size = new System.Drawing.Size(41, 13);
            this.lbl_song_author.TabIndex = 9;
            this.lbl_song_author.Text = "Gorillaz";
            // 
            // lbl_song_album
            // 
            this.lbl_song_album.AutoSize = true;
            this.lbl_song_album.Location = new System.Drawing.Point(130, 83);
            this.lbl_song_album.Name = "lbl_song_album";
            this.lbl_song_album.Size = new System.Drawing.Size(68, 13);
            this.lbl_song_album.TabIndex = 10;
            this.lbl_song_album.Text = "Demon Days";
            // 
            // lbl_song_name
            // 
            this.lbl_song_name.AutoSize = true;
            this.lbl_song_name.Location = new System.Drawing.Point(130, 70);
            this.lbl_song_name.Name = "lbl_song_name";
            this.lbl_song_name.Size = new System.Drawing.Size(74, 13);
            this.lbl_song_name.TabIndex = 11;
            this.lbl_song_name.Text = "Feel Good Inc";
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lblMusicas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRecomendados;
        private System.Windows.Forms.Label lblPlayList;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnBack;
        private ReaLTaiizor.Controls.ParrotSlider parrotSlider1;
        private ReaLTaiizor.Controls.ParrotSlider sldrVolume;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_song_name;
        private System.Windows.Forms.Label lbl_song_album;
        private System.Windows.Forms.Label lbl_song_author;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

