namespace Softver_za_lokalizaciju_signala
{
    partial class FrmMobilniUredjaji
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMobilniUredjaji));
            this.btnGlavniIzbornik = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSaved = new System.Windows.Forms.Label();
            this.mobilniUredjajDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datMobilniUredjaji = new Softver_za_lokalizaciju_signala.Data.DatMobilniUredjaji();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.osobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mobilniUredjajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobilniUredjajTableAdapter = new Softver_za_lokalizaciju_signala.Data.DatMobilniUredjajiTableAdapters.MobilniUredjajTableAdapter();
            this.tableAdapterManager = new Softver_za_lokalizaciju_signala.Data.DatMobilniUredjajiTableAdapters.TableAdapterManager();
            this.lokacijeTableAdapter = new Softver_za_lokalizaciju_signala.Data.DatMobilniUredjajiTableAdapters.LokacijeTableAdapter();
            this.osobeTableAdapter = new Softver_za_lokalizaciju_signala.Data.DatMobilniUredjajiTableAdapters.OsobeTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.labDelete = new System.Windows.Forms.Label();
            this.labAddId = new System.Windows.Forms.Label();
            this.txtAddId = new System.Windows.Forms.TextBox();
            this.labAddLocation = new System.Windows.Forms.Label();
            this.labAddOwner = new System.Windows.Forms.Label();
            this.cboAddLocation = new System.Windows.Forms.ComboBox();
            this.cboAddOwner = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mobilniUredjajDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datMobilniUredjaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilniUredjajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGlavniIzbornik
            // 
            this.btnGlavniIzbornik.Location = new System.Drawing.Point(461, 322);
            this.btnGlavniIzbornik.Name = "btnGlavniIzbornik";
            this.btnGlavniIzbornik.Size = new System.Drawing.Size(92, 23);
            this.btnGlavniIzbornik.TabIndex = 2;
            this.btnGlavniIzbornik.Text = "Glavni izbornik";
            this.btnGlavniIzbornik.UseVisualStyleBackColor = true;
            this.btnGlavniIzbornik.Click += new System.EventHandler(this.btnGlavniIzbornik_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSaved
            // 
            this.txtSaved.AutoSize = true;
            this.txtSaved.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSaved.Location = new System.Drawing.Point(312, 327);
            this.txtSaved.Name = "txtSaved";
            this.txtSaved.Size = new System.Drawing.Size(62, 13);
            this.txtSaved.TabIndex = 4;
            this.txtSaved.Text = "Spremljeno!";
            this.txtSaved.Visible = false;
            // 
            // mobilniUredjajDataGridView
            // 
            this.mobilniUredjajDataGridView.AutoGenerateColumns = false;
            this.mobilniUredjajDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mobilniUredjajDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewComboBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.mobilniUredjajDataGridView.DataSource = this.mobilniUredjajBindingSource;
            this.mobilniUredjajDataGridView.Location = new System.Drawing.Point(12, 12);
            this.mobilniUredjajDataGridView.Name = "mobilniUredjajDataGridView";
            this.mobilniUredjajDataGridView.Size = new System.Drawing.Size(570, 304);
            this.mobilniUredjajDataGridView.TabIndex = 4;
            this.mobilniUredjajDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mobilniUredjajDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Mobitela";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Mobitela";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "Lokacija";
            this.dataGridViewComboBoxColumn3.DataSource = this.lokacijeBindingSource;
            this.dataGridViewComboBoxColumn3.DisplayMember = "Naziv";
            this.dataGridViewComboBoxColumn3.HeaderText = "Lokacija";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.ValueMember = "ID_Lokacije";
            this.dataGridViewComboBoxColumn3.Width = 175;
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataMember = "Lokacije";
            this.lokacijeBindingSource.DataSource = this.datMobilniUredjaji;
            // 
            // datMobilniUredjaji
            // 
            this.datMobilniUredjaji.DataSetName = "DatMobilniUredjaji";
            this.datMobilniUredjaji.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.DataPropertyName = "Vlasnik";
            this.dataGridViewComboBoxColumn4.DataSource = this.osobeBindingSource;
            this.dataGridViewComboBoxColumn4.DisplayMember = "Prezime";
            this.dataGridViewComboBoxColumn4.HeaderText = "Vlasnik";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "ID_Osobe";
            this.dataGridViewComboBoxColumn4.Width = 150;
            // 
            // osobeBindingSource
            // 
            this.osobeBindingSource.DataMember = "Osobe";
            this.osobeBindingSource.DataSource = this.datMobilniUredjaji;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Dozvoljen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Dozvoljen";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // mobilniUredjajBindingSource
            // 
            this.mobilniUredjajBindingSource.DataMember = "MobilniUredjaj";
            this.mobilniUredjajBindingSource.DataSource = this.datMobilniUredjaji;
            // 
            // mobilniUredjajTableAdapter
            // 
            this.mobilniUredjajTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LokacijeTableAdapter = null;
            this.tableAdapterManager.MobilniUredjajTableAdapter = this.mobilniUredjajTableAdapter;
            this.tableAdapterManager.OsobeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Softver_za_lokalizaciju_signala.Data.DatMobilniUredjajiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lokacijeTableAdapter
            // 
            this.lokacijeTableAdapter.ClearBeforeFill = true;
            // 
            // osobeTableAdapter
            // 
            this.osobeTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(483, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Izbriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(483, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(377, 445);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteId.TabIndex = 7;
            // 
            // labDelete
            // 
            this.labDelete.AutoSize = true;
            this.labDelete.Location = new System.Drawing.Point(312, 448);
            this.labDelete.Name = "labDelete";
            this.labDelete.Size = new System.Drawing.Size(63, 13);
            this.labDelete.TabIndex = 8;
            this.labDelete.Text = "ID mobitela:";
            // 
            // labAddId
            // 
            this.labAddId.AutoSize = true;
            this.labAddId.Location = new System.Drawing.Point(17, 398);
            this.labAddId.Name = "labAddId";
            this.labAddId.Size = new System.Drawing.Size(63, 13);
            this.labAddId.TabIndex = 10;
            this.labAddId.Text = "ID mobitela:";
            // 
            // txtAddId
            // 
            this.txtAddId.Location = new System.Drawing.Point(86, 395);
            this.txtAddId.Name = "txtAddId";
            this.txtAddId.Size = new System.Drawing.Size(46, 20);
            this.txtAddId.TabIndex = 9;
            // 
            // labAddLocation
            // 
            this.labAddLocation.AutoSize = true;
            this.labAddLocation.Location = new System.Drawing.Point(139, 397);
            this.labAddLocation.Name = "labAddLocation";
            this.labAddLocation.Size = new System.Drawing.Size(50, 13);
            this.labAddLocation.TabIndex = 12;
            this.labAddLocation.Text = "Lokacija:";
            // 
            // labAddOwner
            // 
            this.labAddOwner.AutoSize = true;
            this.labAddOwner.Location = new System.Drawing.Point(315, 397);
            this.labAddOwner.Name = "labAddOwner";
            this.labAddOwner.Size = new System.Drawing.Size(44, 13);
            this.labAddOwner.TabIndex = 14;
            this.labAddOwner.Text = "Vlasnik:";
            // 
            // cboAddLocation
            // 
            this.cboAddLocation.DataSource = this.lokacijeBindingSource;
            this.cboAddLocation.DisplayMember = "Naziv";
            this.cboAddLocation.FormattingEnabled = true;
            this.cboAddLocation.Location = new System.Drawing.Point(188, 394);
            this.cboAddLocation.Name = "cboAddLocation";
            this.cboAddLocation.Size = new System.Drawing.Size(121, 21);
            this.cboAddLocation.TabIndex = 15;
            this.cboAddLocation.ValueMember = "ID_Lokacije";
            // 
            // cboAddOwner
            // 
            this.cboAddOwner.DataSource = this.osobeBindingSource;
            this.cboAddOwner.DisplayMember = "Prezime";
            this.cboAddOwner.FormattingEnabled = true;
            this.cboAddOwner.Location = new System.Drawing.Point(356, 395);
            this.cboAddOwner.Name = "cboAddOwner";
            this.cboAddOwner.Size = new System.Drawing.Size(121, 21);
            this.cboAddOwner.TabIndex = 16;
            this.cboAddOwner.ValueMember = "ID_Osobe";
            // 
            // FrmMobilniUredjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 501);
            this.Controls.Add(this.cboAddOwner);
            this.Controls.Add(this.cboAddLocation);
            this.Controls.Add(this.labAddOwner);
            this.Controls.Add(this.labAddLocation);
            this.Controls.Add(this.labAddId);
            this.Controls.Add(this.txtAddId);
            this.Controls.Add(this.labDelete);
            this.Controls.Add(this.txtDeleteId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mobilniUredjajDataGridView);
            this.Controls.Add(this.txtSaved);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGlavniIzbornik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMobilniUredjaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMobilniUredjaji";
            this.Load += new System.EventHandler(this.FrmMobilniUredjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mobilniUredjajDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datMobilniUredjaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilniUredjajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DatMobilniUredjaji datMobilniUredjaji;
        private System.Windows.Forms.BindingSource mobilniUredjajBindingSource;
        private Data.DatMobilniUredjajiTableAdapters.MobilniUredjajTableAdapter mobilniUredjajTableAdapter;
        private Data.DatMobilniUredjajiTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnGlavniIzbornik;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtSaved;
        private System.Windows.Forms.DataGridView mobilniUredjajDataGridView;
        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private Data.DatMobilniUredjajiTableAdapters.LokacijeTableAdapter lokacijeTableAdapter;
        private System.Windows.Forms.BindingSource osobeBindingSource;
        private Data.DatMobilniUredjajiTableAdapters.OsobeTableAdapter osobeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label labDelete;
        private System.Windows.Forms.Label labAddId;
        private System.Windows.Forms.TextBox txtAddId;
        private System.Windows.Forms.Label labAddLocation;
        private System.Windows.Forms.Label labAddOwner;
        private System.Windows.Forms.ComboBox cboAddLocation;
        private System.Windows.Forms.ComboBox cboAddOwner;
    }
}