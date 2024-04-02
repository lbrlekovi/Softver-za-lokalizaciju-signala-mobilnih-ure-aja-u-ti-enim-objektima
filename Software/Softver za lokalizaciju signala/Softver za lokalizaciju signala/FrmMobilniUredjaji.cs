using DBLayer;
using Softver_za_lokalizaciju_signala.Models;
using Softver_za_lokalizaciju_signala.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softver_za_lokalizaciju_signala
{
    public partial class FrmMobilniUredjaji : Form
    {
        public FrmMobilniUredjaji()
        {
            InitializeComponent();
        }

        private void mobilniUredjajBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mobilniUredjajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datMobilniUredjaji);

        }

        private void FrmMobilniUredjaji_Load(object sender, EventArgs e)
        {
            this.osobeTableAdapter.Fill(this.datMobilniUredjaji.Osobe);
            this.lokacijeTableAdapter.Fill(this.datMobilniUredjaji.Lokacije);
            this.mobilniUredjajTableAdapter.Fill(this.datMobilniUredjaji.MobilniUredjaj);
        }

        private void btnGlavniIzbornik_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.mobilniUredjajTableAdapter.Update(this.datMobilniUredjaji.MobilniUredjaj);
            txtSaved.Visible = true;
        }

        private void mobilniUredjajDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSaved.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            string sql = "DELETE from MobilniUredjaj WHERE ID_Mobitela = " + txtDeleteId.Text;
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            this.osobeTableAdapter.Fill(this.datMobilniUredjaji.Osobe);
            this.lokacijeTableAdapter.Fill(this.datMobilniUredjaji.Lokacije);
            this.mobilniUredjajTableAdapter.Fill(this.datMobilniUredjaji.MobilniUredjaj);
            txtDeleteId.Text = "";
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.SetConfiguration("lbrlekovi20_DB", "lbrlekovi20", "G}ex!}H0");
            string sql = "INSERT INTO MobilniUredjaj VALUES (" + txtAddId.Text + ", " + cboAddLocation.SelectedValue + ", " + cboAddOwner.SelectedValue + ", " + "1)";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            this.osobeTableAdapter.Fill(this.datMobilniUredjaji.Osobe);
            this.lokacijeTableAdapter.Fill(this.datMobilniUredjaji.Lokacije);
            this.mobilniUredjajTableAdapter.Fill(this.datMobilniUredjaji.MobilniUredjaj);
            return;
        }
    }
}
