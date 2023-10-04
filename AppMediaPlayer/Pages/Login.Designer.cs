namespace AppMediaPlayer.Pages
{
    partial class Login
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
            this.btnFechar = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new ReaLTaiizor.Controls.CyberButton();
            this.aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            this.txtUsuario = new ReaLTaiizor.Controls.CyberTextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(754, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 33);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(165, 187);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(486, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Alpha = 20;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Background = true;
            this.btnLogin.Background_WidthPen = 4F;
            this.btnLogin.BackgroundPen = true;
            this.btnLogin.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnLogin.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnLogin.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnLogin.ColorBackground_Pen = System.Drawing.Color.DodgerBlue;
            this.btnLogin.ColorLighting = System.Drawing.Color.DodgerBlue;
            this.btnLogin.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnLogin.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnLogin.Effect_1 = true;
            this.btnLogin.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnLogin.Effect_1_Transparency = 25;
            this.btnLogin.Effect_2 = true;
            this.btnLogin.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnLogin.Effect_2_Transparency = 20;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnLogin.Lighting = false;
            this.btnLogin.LinearGradient_Background = false;
            this.btnLogin.LinearGradientPen = false;
            this.btnLogin.Location = new System.Drawing.Point(329, 364);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PenWidth = 15;
            this.btnLogin.Rounding = true;
            this.btnLogin.RoundingInt = 70;
            this.btnLogin.Size = new System.Drawing.Size(130, 50);
            this.btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Tag = "Cyber";
            this.btnLogin.TextButton = "Logar";
            this.btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnLogin.Timer_Effect_1 = 5;
            this.btnLogin.Timer_RGB = 300;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // aloneTextBox1
            // 
            this.aloneTextBox1.BackColor = System.Drawing.Color.White;
            this.aloneTextBox1.EnabledCalc = true;
            this.aloneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aloneTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.aloneTextBox1.Location = new System.Drawing.Point(110, 223);
            this.aloneTextBox1.MaxLength = 32767;
            this.aloneTextBox1.MultiLine = false;
            this.aloneTextBox1.Name = "aloneTextBox1";
            this.aloneTextBox1.ReadOnly = false;
            this.aloneTextBox1.Size = new System.Drawing.Size(434, 98);
            this.aloneTextBox1.TabIndex = 6;
            this.aloneTextBox1.Text = "aloneTextBox1";
            this.aloneTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Alpha = 20;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.Background_WidthPen = 3F;
            this.txtUsuario.BackgroundPen = true;
            this.txtUsuario.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtUsuario.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsuario.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsuario.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsuario.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtUsuario.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsuario.Lighting = false;
            this.txtUsuario.LinearGradientPen = false;
            this.txtUsuario.Location = new System.Drawing.Point(247, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PenWidth = 15;
            this.txtUsuario.RGB = false;
            this.txtUsuario.Rounding = true;
            this.txtUsuario.RoundingInt = 60;
            this.txtUsuario.Size = new System.Drawing.Size(200, 40);
            this.txtUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Tag = "Cyber";
            this.txtUsuario.TextButton = "";
            this.txtUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtUsuario.Timer_RGB = 300;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.aloneTextBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnFechar;
        private System.Windows.Forms.TextBox txtSenha;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.CyberTextBox txtUsuario;
    }
}