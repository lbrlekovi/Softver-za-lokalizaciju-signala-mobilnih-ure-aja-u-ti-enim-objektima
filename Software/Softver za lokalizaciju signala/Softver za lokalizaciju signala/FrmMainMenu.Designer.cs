namespace Softver_za_lokalizaciju_signala
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnPopisMobilnihUredjaja = new System.Windows.Forms.Button();
            this.btnPrikazMobilnihUredjaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopisMobilnihUredjaja
            // 
            this.btnPopisMobilnihUredjaja.Location = new System.Drawing.Point(105, 21);
            this.btnPopisMobilnihUredjaja.Name = "btnPopisMobilnihUredjaja";
            this.btnPopisMobilnihUredjaja.Size = new System.Drawing.Size(160, 23);
            this.btnPopisMobilnihUredjaja.TabIndex = 0;
            this.btnPopisMobilnihUredjaja.Text = "Popis Mobilnih Uređaja";
            this.btnPopisMobilnihUredjaja.UseVisualStyleBackColor = true;
            this.btnPopisMobilnihUredjaja.Click += new System.EventHandler(this.btnPopisMobilnihUredjaja_Click);
            // 
            // btnPrikazMobilnihUredjaja
            // 
            this.btnPrikazMobilnihUredjaja.Location = new System.Drawing.Point(105, 50);
            this.btnPrikazMobilnihUredjaja.Name = "btnPrikazMobilnihUredjaja";
            this.btnPrikazMobilnihUredjaja.Size = new System.Drawing.Size(160, 23);
            this.btnPrikazMobilnihUredjaja.TabIndex = 1;
            this.btnPrikazMobilnihUredjaja.Text = "Prikaz Mobilnih Uređaja";
            this.btnPrikazMobilnihUredjaja.UseVisualStyleBackColor = true;
            this.btnPrikazMobilnihUredjaja.Click += new System.EventHandler(this.btnPrikazMobilnihUredjaja_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 163);
            this.Controls.Add(this.btnPrikazMobilnihUredjaja);
            this.Controls.Add(this.btnPopisMobilnihUredjaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopisMobilnihUredjaja;
        private System.Windows.Forms.Button btnPrikazMobilnihUredjaja;
    }
}