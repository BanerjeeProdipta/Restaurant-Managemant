namespace Restaurant_Management
{
    partial class LoginPage
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
            this.txtLoginId = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginPassword = new MetroFramework.Controls.MetroTextBox();
            this.mbtnLogin = new MetroFramework.Controls.MetroButton();
            this.ckbShowPassword = new MetroFramework.Controls.MetroCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginId
            // 
            // 
            // 
            // 
            this.txtLoginId.CustomButton.Image = null;
            this.txtLoginId.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtLoginId.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginId.CustomButton.Name = "";
            this.txtLoginId.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtLoginId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginId.CustomButton.TabIndex = 1;
            this.txtLoginId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginId.CustomButton.UseSelectable = true;
            this.txtLoginId.CustomButton.Visible = false;
            this.txtLoginId.Lines = new string[0];
            this.txtLoginId.Location = new System.Drawing.Point(43, 252);
            this.txtLoginId.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginId.MaxLength = 32767;
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.PasswordChar = '\0';
            this.txtLoginId.PromptText = "User ID";
            this.txtLoginId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginId.SelectedText = "";
            this.txtLoginId.SelectionLength = 0;
            this.txtLoginId.SelectionStart = 0;
            this.txtLoginId.ShortcutsEnabled = true;
            this.txtLoginId.Size = new System.Drawing.Size(165, 19);
            this.txtLoginId.TabIndex = 2;
            this.txtLoginId.UseSelectable = true;
            this.txtLoginId.WaterMark = "User ID";
            this.txtLoginId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLoginPassword
            // 
            // 
            // 
            // 
            this.txtLoginPassword.CustomButton.Image = null;
            this.txtLoginPassword.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtLoginPassword.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginPassword.CustomButton.Name = "";
            this.txtLoginPassword.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtLoginPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginPassword.CustomButton.TabIndex = 1;
            this.txtLoginPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginPassword.CustomButton.UseSelectable = true;
            this.txtLoginPassword.CustomButton.Visible = false;
            this.txtLoginPassword.Lines = new string[0];
            this.txtLoginPassword.Location = new System.Drawing.Point(43, 306);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginPassword.MaxLength = 32767;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '\0';
            this.txtLoginPassword.PromptText = "Password";
            this.txtLoginPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.SelectionLength = 0;
            this.txtLoginPassword.SelectionStart = 0;
            this.txtLoginPassword.ShortcutsEnabled = true;
            this.txtLoginPassword.Size = new System.Drawing.Size(165, 19);
            this.txtLoginPassword.TabIndex = 3;
            this.txtLoginPassword.UseSelectable = true;
            this.txtLoginPassword.WaterMark = "Password";
            this.txtLoginPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mbtnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mbtnLogin.Location = new System.Drawing.Point(157, 397);
            this.mbtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(76, 25);
            this.mbtnLogin.TabIndex = 4;
            this.mbtnLogin.Text = "Login";
            this.mbtnLogin.UseCustomBackColor = true;
            this.mbtnLogin.UseCustomForeColor = true;
            this.mbtnLogin.UseSelectable = true;
            this.mbtnLogin.UseStyleColors = true;
            this.mbtnLogin.Click += new System.EventHandler(this.MbtnLogin_Click);
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ckbShowPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ckbShowPassword.Location = new System.Drawing.Point(43, 360);
            this.ckbShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(105, 15);
            this.ckbShowPassword.TabIndex = 5;
            this.ckbShowPassword.Text = "Show Password";
            this.ckbShowPassword.UseCustomBackColor = true;
            this.ckbShowPassword.UseCustomForeColor = true;
            this.ckbShowPassword.UseSelectable = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.MetroCheckBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.mbtnLogin);
            this.panel1.Controls.Add(this.txtLoginPassword);
            this.panel1.Controls.Add(this.txtLoginId);
            this.panel1.Controls.Add(this.ckbShowPassword);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 461);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management.Properties.Resources.restaurantfinal5_1;
            this.pictureBox1.Location = new System.Drawing.Point(238, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtLoginId;
        private MetroFramework.Controls.MetroTextBox txtLoginPassword;
        private MetroFramework.Controls.MetroButton mbtnLogin;
        private MetroFramework.Controls.MetroCheckBox ckbShowPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

