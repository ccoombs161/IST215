using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons_with_Images
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		
		private void btnNH_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			lblOutput.Text = string.Format($"Welcome to {btn.Text}");
		}

		private void btnMA_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			lblOutput.Text = string.Format($"Welcome to {btn.Text}");
		}

		private void btnRedDevil_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			lblOutput.Text = string.Format($"Welcome to {btn.Text}");
		}

		private void btnWhiteAlien_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			lblOutput.Text = string.Format($"Welcome to {btn.Text}");
		}

		private void btnVT_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			lblOutput.Text = string.Format($"Welcome to {btn.Text}");
		}

		private void btnDuck_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			lblOutput.Text = string.Format($"Welcome to {btn.Text}");
		}
	}
}
