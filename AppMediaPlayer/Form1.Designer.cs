﻿namespace AppMediaPlayer
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
            this.lbl_forms = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.lbl_control = new System.Windows.Forms.Panel();
            this.scrRolagemMusicas = new System.Windows.Forms.VScrollBar();
            this.lbl_Musicas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lbl_forms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.lbl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblRecomendados.Location = new System.Drawing.Point(23, 313);
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
            this.lblPlayList.Location = new System.Drawing.Point(23, 226);
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
            // lbl_forms
            // 
            this.lbl_forms.BackColor = System.Drawing.Color.Pink;
            this.lbl_forms.Controls.Add(this.btnPlay);
            this.lbl_forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_forms.Location = new System.Drawing.Point(227, 641);
            this.lbl_forms.Name = "lbl_forms";
            this.lbl_forms.Size = new System.Drawing.Size(1045, 124);
            this.lbl_forms.TabIndex = 1;
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
            // lbl_control
            // 
            this.lbl_control.BackColor = System.Drawing.Color.Green;
            this.lbl_control.Controls.Add(this.lbl_Musicas);
            this.lbl_control.Controls.Add(this.scrRolagemMusicas);
            this.lbl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_control.Location = new System.Drawing.Point(227, 99);
            this.lbl_control.Name = "lbl_control";
            this.lbl_control.Size = new System.Drawing.Size(1045, 542);
            this.lbl_control.TabIndex = 2;
            // 
            // scrRolagemMusicas
            // 
            this.scrRolagemMusicas.Dock = System.Windows.Forms.DockStyle.Left;
            this.scrRolagemMusicas.Location = new System.Drawing.Point(0, 0);
            this.scrRolagemMusicas.Name = "scrRolagemMusicas";
            this.scrRolagemMusicas.Size = new System.Drawing.Size(17, 542);
            this.scrRolagemMusicas.TabIndex = 0;
            // 
            // lbl_Musicas
            // 
            this.lbl_Musicas.BackColor = System.Drawing.Color.Tomato;
            this.lbl_Musicas.Location = new System.Drawing.Point(76, 40);
            this.lbl_Musicas.Name = "lbl_Musicas";
            this.lbl_Musicas.Size = new System.Drawing.Size(913, 462);
            this.lbl_Musicas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1272, 765);
            this.Controls.Add(this.lbl_control);
            this.Controls.Add(this.lbl_forms);
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
            this.lbl_forms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.lbl_control.ResumeLayout(false);
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
        private System.Windows.Forms.Panel lbl_forms;
        private System.Windows.Forms.Panel lbl_control;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.VScrollBar scrRolagemMusicas;
        private System.Windows.Forms.Panel lbl_Musicas;
    }
}

