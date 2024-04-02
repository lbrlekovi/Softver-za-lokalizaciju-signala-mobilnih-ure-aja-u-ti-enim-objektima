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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnPopisMobilnihUredjaja_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMobilniUredjaji frmMobilniUredjaji = new FrmMobilniUredjaji();
            frmMobilniUredjaji.ShowDialog();
            Close();
        }

        private void btnPrikazMobilnihUredjaja_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMap frmMap = new FrmMap();
            frmMap.ShowDialog();
            Close();
        }
    }
}
