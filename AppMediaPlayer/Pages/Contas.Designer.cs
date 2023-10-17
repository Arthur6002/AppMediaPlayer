namespace AppMediaPlayer.Pages
{
    partial class Contas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Label();
            this.crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            this.pnlAdicionar = new System.Windows.Forms.Panel();
            this.pcbAdicionar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_add = new System.Windows.Forms.Panel();
            this.pb_add = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdicionar)).BeginInit();
            this.pnl_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnFechar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(754, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 33);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // crownDockPanel1
            // 
            this.crownDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownDockPanel1.Location = new System.Drawing.Point(-3, -1);
            this.crownDockPanel1.Name = "crownDockPanel1";
            this.crownDockPanel1.Size = new System.Drawing.Size(846, 60);
            this.crownDockPanel1.TabIndex = 22;
            this.crownDockPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crownDockPanel1_MouseDown);
            // 
            // pnlAdicionar
            // 
            this.pnlAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlAdicionar.Controls.Add(this.pcbAdicionar);
            this.pnlAdicionar.Location = new System.Drawing.Point(205, 129);
            this.pnlAdicionar.Name = "pnlAdicionar";
            this.pnlAdicionar.Size = new System.Drawing.Size(183, 193);
            this.pnlAdicionar.TabIndex = 27;
            // 
            // pcbAdicionar
            // 
            this.pcbAdicionar.Image = global::AppMediaPlayer.Properties.Resources.Plus512;
            this.pcbAdicionar.Location = new System.Drawing.Point(31, 43);
            this.pcbAdicionar.Name = "pcbAdicionar";
            this.pcbAdicionar.Size = new System.Drawing.Size(120, 107);
            this.pcbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAdicionar.TabIndex = 0;
            this.pcbAdicionar.TabStop = false;
            this.pcbAdicionar.Click += new System.EventHandler(this.pcbAdicionar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adicionar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Login";
            // 
            // pnl_add
            // 
            this.pnl_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_add.Controls.Add(this.pb_add);
            this.pnl_add.Location = new System.Drawing.Point(412, 129);
            this.pnl_add.Name = "pnl_add";
            this.pnl_add.Size = new System.Drawing.Size(183, 193);
            this.pnl_add.TabIndex = 29;
            this.pnl_add.Click += new System.EventHandler(this.pnl_add_Click);
            // 
            // pb_add
            // 
            this.pb_add.Image = global::AppMediaPlayer.Properties.Resources.Plus512;
            this.pb_add.Location = new System.Drawing.Point(31, 43);
            this.pb_add.Name = "pb_add";
            this.pb_add.Size = new System.Drawing.Size(120, 107);
            this.pb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_add.TabIndex = 0;
            this.pb_add.TabStop = false;
            this.pb_add.Click += new System.EventHandler(this.pb_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlAdicionar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.crownDockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.pnlAdicionar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdicionar)).EndInit();
            this.pnl_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnFechar;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAdicionar;
        private System.Windows.Forms.PictureBox pcbAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_add;
        private System.Windows.Forms.PictureBox pb_add;
    }
}