namespace Softver_za_lokalizaciju_signala
{
    partial class FrmLogin
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
            this.uiLabelUsername = new System.Windows.Forms.Label();
            this.uiLabelPassword = new System.Windows.Forms.Label();
            this.uiTextboxUsername = new System.Windows.Forms.TextBox();
            this.uiTextboxPassword = new System.Windows.Forms.TextBox();
            this.uiButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiLabelUsername
            // 
            this.uiLabelUsername.AutoSize = true;
            this.uiLabelUsername.Location = new System.Drawing.Point(26, 23);
            this.uiLabelUsername.Name = "uiLabelUsername";
            this.uiLabelUsername.Size = new System.Drawing.Size(78, 13);
            this.uiLabelUsername.TabIndex = 0;
            this.uiLabelUsername.Text = "Korisničko ime:";
            // 
            // uiLabelPassword
            // 
            this.uiLabelPassword.AutoSize = true;
            this.uiLabelPassword.Location = new System.Drawing.Point(57, 60);
            this.uiLabelPassword.Name = "uiLabelPassword";
            this.uiLabelPassword.Size = new System.Drawing.Size(47, 13);
            this.uiLabelPassword.TabIndex = 1;
            this.uiLabelPassword.Text = "Lozinka:";
            // 
            // uiTextboxUsername
            // 
            this.uiTextboxUsername.Location = new System.Drawing.Point(110, 23);
            this.uiTextboxUsername.Name = "uiTextboxUsername";
            this.uiTextboxUsername.Size = new System.Drawing.Size(146, 20);
            this.uiTextboxUsername.TabIndex = 2;
            // 
            // uiTextboxPassword
            // 
            this.uiTextboxPassword.Location = new System.Drawing.Point(110, 57);
            this.uiTextboxPassword.Name = "uiTextboxPassword";
            this.uiTextboxPassword.Size = new System.Drawing.Size(146, 20);
            this.uiTextboxPassword.TabIndex = 3;
            this.uiTextboxPassword.UseSystemPasswordChar = true;
            // 
            // uiButtonLogin
            // 
            this.uiButtonLogin.Location = new System.Drawing.Point(191, 83);
            this.uiButtonLogin.Name = "uiButtonLogin";
            this.uiButtonLogin.Size = new System.Drawing.Size(65, 34);
            this.uiButtonLogin.TabIndex = 4;
            this.uiButtonLogin.Text = "Uredu";
            this.uiButtonLogin.UseVisualStyleBackColor = true;
            this.uiButtonLogin.Click += new System.EventHandler(this.uiButtonLogin_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.uiButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 139);
            this.Controls.Add(this.uiButtonLogin);
            this.Controls.Add(this.uiTextboxPassword);
            this.Controls.Add(this.uiTextboxUsername);
            this.Controls.Add(this.uiLabelPassword);
            this.Controls.Add(this.uiLabelUsername);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLabelUsername;
        private System.Windows.Forms.Label uiLabelPassword;
        private System.Windows.Forms.TextBox uiTextboxUsername;
        private System.Windows.Forms.TextBox uiTextboxPassword;
        private System.Windows.Forms.Button uiButtonLogin;
    }
}

