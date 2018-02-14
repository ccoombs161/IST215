using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtEnterText.Text;
          /*Button b = (Button)sender;
            string bName = b.Name;
            MessageBox.Show("Caption of MsgBox", bName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
          */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterText.Text = string.Empty;
            1b1Output.Text = string.Empty;
        }
    }
}
