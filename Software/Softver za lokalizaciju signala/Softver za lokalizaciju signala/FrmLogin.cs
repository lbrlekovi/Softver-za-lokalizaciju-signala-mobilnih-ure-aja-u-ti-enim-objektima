using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softver_za_lokalizaciju_signala
{
    public partial class FrmLogin : Form
    {
        static string admin_username = "admin";
        static string admin_password = "pass";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void uiButtonLogin_Click(object sender, EventArgs e)
        {
            if (uiTextboxUsername.Text == admin_username && uiTextboxPassword.Text == admin_password)
            {
                MessageBox.Show("Dobrodošli!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                Hide();
                frmMainMenu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Unešeni podatci su netočni", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
