namespace Softver_za_lokalizaciju_signala
{
    partial class FrmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMap));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.btnMobileDevice = new System.Windows.Forms.Button();
            this.txtIdMobileDevice = new System.Windows.Forms.Label();
            this.valIdMobileDevice = new System.Windows.Forms.Label();
            this.txtVlasnik = new System.Windows.Forms.Label();
            this.valVlasnik = new System.Windows.Forms.Label();
            this.txtBrojPrekrsaja = new System.Windows.Forms.Label();
            this.valBrojPrekrsaja = new System.Windows.Forms.Label();
            this.txtDozvoljen = new System.Windows.Forms.Label();
            this.valDozvoljen = new System.Windows.Forms.Label();
            this.txtUloga = new System.Windows.Forms.Label();
            this.valUloga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(1250, 595);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(85, 23);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Glavni izbornik";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // picMap
            // 
            this.picMap.Image = ((System.Drawing.Image)(resources.GetObject("picMap.Image")));
            this.picMap.Location = new System.Drawing.Point(12, 12);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(1034, 640);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            // 
            // btnMobileDevice
            // 
            this.btnMobileDevice.Location = new System.Drawing.Point(1083, 95);
            this.btnMobileDevice.Name = "btnMobileDevice";
            this.btnMobileDevice.Size = new System.Drawing.Size(22, 22);
            this.btnMobileDevice.TabIndex = 1;
            this.btnMobileDevice.UseVisualStyleBackColor = true;
            // 
            // txtIdMobileDevice
            // 
            this.txtIdMobileDevice.AutoSize = true;
            this.txtIdMobileDevice.Location = new System.Drawing.Point(1116, 222);
            this.txtIdMobileDevice.Name = "txtIdMobileDevice";
            this.txtIdMobileDevice.Size = new System.Drawing.Size(21, 13);
            this.txtIdMobileDevice.TabIndex = 3;
            this.txtIdMobileDevice.Text = "ID:";
            // 
            // valIdMobileDevice
            // 
            this.valIdMobileDevice.AutoSize = true;
            this.valIdMobileDevice.Location = new System.Drawing.Point(1143, 222);
            this.valIdMobileDevice.Name = "valIdMobileDevice";
            this.valIdMobileDevice.Size = new System.Drawing.Size(18, 13);
            this.valIdMobileDevice.TabIndex = 4;
            this.valIdMobileDevice.Text = "ID";
            this.valIdMobileDevice.Visible = false;
            // 
            // txtVlasnik
            // 
            this.txtVlasnik.AutoSize = true;
            this.txtVlasnik.Location = new System.Drawing.Point(1093, 245);
            this.txtVlasnik.Name = "txtVlasnik";
            this.txtVlasnik.Size = new System.Drawing.Size(44, 13);
            this.txtVlasnik.TabIndex = 5;
            this.txtVlasnik.Text = "Vlasnik:";
            // 
            // valVlasnik
            // 
            this.valVlasnik.AutoSize = true;
            this.valVlasnik.Location = new System.Drawing.Point(1143, 245);
            this.valVlasnik.Name = "valVlasnik";
            this.valVlasnik.Size = new System.Drawing.Size(41, 13);
            this.valVlasnik.TabIndex = 6;
            this.valVlasnik.Text = "Vlasnik";
            this.valVlasnik.Visible = false;
            // 
            // txtBrojPrekrsaja
            // 
            this.txtBrojPrekrsaja.AutoSize = true;
            this.txtBrojPrekrsaja.Location = new System.Drawing.Point(1063, 293);
            this.txtBrojPrekrsaja.Name = "txtBrojPrekrsaja";
            this.txtBrojPrekrsaja.Size = new System.Drawing.Size(74, 13);
            this.txtBrojPrekrsaja.TabIndex = 7;
            this.txtBrojPrekrsaja.Text = "Broj prekršaja:";
            // 
            // valBrojPrekrsaja
            // 
            this.valBrojPrekrsaja.AutoSize = true;
            this.valBrojPrekrsaja.Location = new System.Drawing.Point(1143, 293);
            this.valBrojPrekrsaja.Name = "valBrojPrekrsaja";
            this.valBrojPrekrsaja.Size = new System.Drawing.Size(71, 13);
            this.valBrojPrekrsaja.TabIndex = 8;
            this.valBrojPrekrsaja.Text = "Broj prekršaja";
            this.valBrojPrekrsaja.Visible = false;
            // 
            // txtDozvoljen
            // 
            this.txtDozvoljen.AutoSize = true;
            this.txtDozvoljen.Location = new System.Drawing.Point(1080, 319);
            this.txtDozvoljen.Name = "txtDozvoljen";
            this.txtDozvoljen.Size = new System.Drawing.Size(57, 13);
            this.txtDozvoljen.TabIndex = 9;
            this.txtDozvoljen.Text = "Dozvoljen:";
            // 
            // valDozvoljen
            // 
            this.valDozvoljen.AutoSize = true;
            this.valDozvoljen.Location = new System.Drawing.Point(1143, 319);
            this.valDozvoljen.Name = "valDozvoljen";
            this.valDozvoljen.Size = new System.Drawing.Size(54, 13);
            this.valDozvoljen.TabIndex = 10;
            this.valDozvoljen.Text = "Dozvoljen";
            this.valDozvoljen.Visible = false;
            // 
            // txtUloga
            // 
            this.txtUloga.AutoSize = true;
            this.txtUloga.Location = new System.Drawing.Point(1093, 270);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(38, 13);
            this.txtUloga.TabIndex = 11;
            this.txtUloga.Text = "Uloga:";
            // 
            // valUloga
            // 
            this.valUloga.AutoSize = true;
            this.valUloga.Location = new System.Drawing.Point(1143, 270);
            this.valUloga.Name = "valUloga";
            this.valUloga.Size = new System.Drawing.Size(35, 13);
            this.valUloga.TabIndex = 12;
            this.valUloga.Text = "Uloga";
            this.valUloga.Visible = false;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 674);
            this.Controls.Add(this.valUloga);
            this.Controls.Add(this.txtUloga);
            this.Controls.Add(this.valDozvoljen);
            this.Controls.Add(this.txtDozvoljen);
            this.Controls.Add(this.valBrojPrekrsaja);
            this.Controls.Add(this.txtBrojPrekrsaja);
            this.Controls.Add(this.valVlasnik);
            this.Controls.Add(this.txtVlasnik);
            this.Controls.Add(this.valIdMobileDevice);
            this.Controls.Add(this.txtIdMobileDevice);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnMobileDevice);
            this.Controls.Add(this.picMap);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafički prikaz mobilnih uređaja na tlocrtu";
            this.Load += new System.EventHandler(this.FrmMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Button btnMobileDevice;
        private System.Windows.Forms.Label txtIdMobileDevice;
        private System.Windows.Forms.Label valIdMobileDevice;
        private System.Windows.Forms.Label txtVlasnik;
        private System.Windows.Forms.Label valVlasnik;
        private System.Windows.Forms.Label txtBrojPrekrsaja;
        private System.Windows.Forms.Label valBrojPrekrsaja;
        private System.Windows.Forms.Label txtDozvoljen;
        private System.Windows.Forms.Label valDozvoljen;
        private System.Windows.Forms.Label txtUloga;
        private System.Windows.Forms.Label valUloga;
    }
}