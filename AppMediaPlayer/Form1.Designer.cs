namespace AppMediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecomendados = new System.Windows.Forms.Label();
            this.lblPlayList = new System.Windows.Forms.Label();
            this.lblMusicas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.flpMusicas = new System.Windows.Forms.FlowLayoutPanel();
            this.scrRolagemMusicas = new System.Windows.Forms.VScrollBar();
            this.flpPlaylists = new System.Windows.Forms.FlowLayoutPanel();
            this.scrPlaylists = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.scrPlaylists);
            this.panel1.Controls.Add(this.flpPlaylists);
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
            this.lblRecomendados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecomendados.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendados.ForeColor = System.Drawing.Color.White;
            this.lblRecomendados.Location = new System.Drawing.Point(23, 237);
            this.lblRecomendados.Name = "lblRecomendados";
            this.lblRecomendados.Size = new System.Drawing.Size(156, 24);
            this.lblRecomendados.TabIndex = 7;
            this.lblRecomendados.Text = "Recomendados";
            this.lblRecomendados.Click += new System.EventHandler(this.lblRecomendados_Click);
            this.lblRecomendados.MouseEnter += new System.EventHandler(this.lblRecomendados_MouseEnter);
            this.lblRecomendados.MouseLeave += new System.EventHandler(this.lblRecomendados_MouseLeave);
            // 
            // lblPlayList
            // 
            this.lblPlayList.AutoSize = true;
            this.lblPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayList.ForeColor = System.Drawing.Color.White;
            this.lblPlayList.Location = new System.Drawing.Point(23, 335);
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
            this.lblMusicas.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
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
            this.pictureBox1.Location = new System.Drawing.Point(26, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.Pink;
            this.pnlControles.Controls.Add(this.btnPlay);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControles.Location = new System.Drawing.Point(227, 641);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(1045, 124);
            this.pnlControles.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(481, 43);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 69);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 2;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Green;
            this.pnlControl.Controls.Add(this.scrRolagemMusicas);
            this.pnlControl.Controls.Add(this.flpMusicas);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(227, 99);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1045, 542);
            this.pnlControl.TabIndex = 2;
            // 
            // flpMusicas
            // 
            this.flpMusicas.BackColor = System.Drawing.Color.Tomato;
            this.flpMusicas.Location = new System.Drawing.Point(50, 40);
            this.flpMusicas.Name = "flpMusicas";
            this.flpMusicas.Size = new System.Drawing.Size(950, 463);
            this.flpMusicas.TabIndex = 1;
            // 
            // scrRolagemMusicas
            // 
            this.scrRolagemMusicas.LargeChange = 30;
            this.scrRolagemMusicas.Location = new System.Drawing.Point(30, 40);
            this.scrRolagemMusicas.Name = "scrRolagemMusicas";
            this.scrRolagemMusicas.Size = new System.Drawing.Size(17, 463);
            this.scrRolagemMusicas.TabIndex = 0;
            this.scrRolagemMusicas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrRolagemMusicas_Scroll);
            // 
            // flpPlaylists
            // 
            this.flpPlaylists.BackColor = System.Drawing.Color.Tomato;
            this.flpPlaylists.Location = new System.Drawing.Point(27, 371);
            this.flpPlaylists.Name = "flpPlaylists";
            this.flpPlaylists.Size = new System.Drawing.Size(191, 270);
            this.flpPlaylists.TabIndex = 2;
            // 
            // scrPlaylists
            // 
            this.scrPlaylists.LargeChange = 30;
            this.scrPlaylists.Location = new System.Drawing.Point(9, 371);
            this.scrPlaylists.Name = "scrPlaylists";
            this.scrPlaylists.Size = new System.Drawing.Size(17, 270);
            this.scrPlaylists.TabIndex = 2;
            this.scrPlaylists.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrPlaylists_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1272, 765);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusicas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRecomendados;
        private System.Windows.Forms.Label lblPlayList;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.FlowLayoutPanel flpMusicas;
        private System.Windows.Forms.VScrollBar scrRolagemMusicas;
        private System.Windows.Forms.VScrollBar scrPlaylists;
        private System.Windows.Forms.FlowLayoutPanel flpPlaylists;
    }
}

