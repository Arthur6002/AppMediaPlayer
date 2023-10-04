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
            this.btnLogin = new ReaLTaiizor.Controls.CyberButton();
            this.txtSenha = new ReaLTaiizor.Controls.CyberTextBox();
            this.txtUsuario = new ReaLTaiizor.Controls.CyberTextBox();
            this.rdbMostrarSenha = new ReaLTaiizor.Controls.CyberRadioButton();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(572, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 33);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Alpha = 20;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Background = true;
            this.btnLogin.Background_WidthPen = 4F;
            this.btnLogin.BackgroundPen = true;
            this.btnLogin.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
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
            this.btnLogin.Location = new System.Drawing.Point(233, 320);
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
            // txtSenha
            // 
            this.txtSenha.Alpha = 20;
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.Background_WidthPen = 3F;
            this.txtSenha.BackgroundPen = true;
            this.txtSenha.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtSenha.ColorBackground_Pen = System.Drawing.Color.DodgerBlue;
            this.txtSenha.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtSenha.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtSenha.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 16F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSenha.Lighting = false;
            this.txtSenha.LinearGradientPen = false;
            this.txtSenha.Location = new System.Drawing.Point(187, 176);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Password = true;
            this.txtSenha.PenWidth = 15;
            this.txtSenha.RGB = false;
            this.txtSenha.Rounding = true;
            this.txtSenha.RoundingInt = 60;
            this.txtSenha.Size = new System.Drawing.Size(223, 65);
            this.txtSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Tag = "Cyber";
            this.txtSenha.TextButton = "";
            this.txtSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtSenha.Timer_RGB = 300;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Alpha = 20;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.Background_WidthPen = 3F;
            this.txtUsuario.BackgroundPen = true;
            this.txtUsuario.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtUsuario.ColorBackground_Pen = System.Drawing.Color.DodgerBlue;
            this.txtUsuario.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsuario.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txtUsuario.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.txtUsuario.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 16F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsuario.Lighting = false;
            this.txtUsuario.LinearGradientPen = false;
            this.txtUsuario.Location = new System.Drawing.Point(187, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PenWidth = 15;
            this.txtUsuario.RGB = false;
            this.txtUsuario.Rounding = true;
            this.txtUsuario.RoundingInt = 60;
            this.txtUsuario.Size = new System.Drawing.Size(223, 65);
            this.txtUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Tag = "Cyber";
            this.txtUsuario.TextButton = "";
            this.txtUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtUsuario.Timer_RGB = 300;
            // 
            // rdbMostrarSenha
            // 
            this.rdbMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.rdbMostrarSenha.Background = true;
            this.rdbMostrarSenha.Background_WidthPen = 2F;
            this.rdbMostrarSenha.BackgroundPen = true;
            this.rdbMostrarSenha.Checked = false;
            this.rdbMostrarSenha.Color_1_Background_value = System.Drawing.Color.Empty;
            this.rdbMostrarSenha.Color_2_Background_value = System.Drawing.Color.Empty;
            this.rdbMostrarSenha.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.rdbMostrarSenha.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.rdbMostrarSenha.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.rdbMostrarSenha.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.rdbMostrarSenha.ColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.rdbMostrarSenha.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.rdbMostrarSenha.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.rdbMostrarSenha.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.rdbMostrarSenha.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.rdbMostrarSenha.Effect_1_Transparency = 25;
            this.rdbMostrarSenha.Effect_2 = true;
            this.rdbMostrarSenha.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.rdbMostrarSenha.Effect_2_Transparency = 15;
            this.rdbMostrarSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.rdbMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.rdbMostrarSenha.LinearGradient_Background = false;
            this.rdbMostrarSenha.LinearGradient_Value = false;
            this.rdbMostrarSenha.LinearGradientPen = false;
            this.rdbMostrarSenha.Location = new System.Drawing.Point(187, 247);
            this.rdbMostrarSenha.Name = "rdbMostrarSenha";
            this.rdbMostrarSenha.RGB = false;
            this.rdbMostrarSenha.Rounding = true;
            this.rdbMostrarSenha.RoundingInt = 100;
            this.rdbMostrarSenha.Size = new System.Drawing.Size(180, 45);
            this.rdbMostrarSenha.SizeChecked = 8;
            this.rdbMostrarSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.rdbMostrarSenha.TabIndex = 10;
            this.rdbMostrarSenha.Tag = "Cyber";
            this.rdbMostrarSenha.TextButton = "Exibir Senha";
            this.rdbMostrarSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.rdbMostrarSenha.Timer_Effect_1 = 1;
            this.rdbMostrarSenha.Timer_RGB = 300;
            this.rdbMostrarSenha.Click += new System.EventHandler(this.rdbMostrarSenha_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.rdbMostrarSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnLogin);
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
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private ReaLTaiizor.Controls.CyberTextBox txtSenha;
        private ReaLTaiizor.Controls.CyberTextBox txtUsuario;
        private ReaLTaiizor.Controls.CyberRadioButton rdbMostrarSenha;
    }
}