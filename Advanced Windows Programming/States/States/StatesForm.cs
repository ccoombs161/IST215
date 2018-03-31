using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace States
{
    public partial class StatesForm : Form
    {
        private static bool IsItemSelected = false;
        private static string[] states;
        private static string[] img;
        public StatesForm()
        {
            InitializeComponent();

            states = new string[] { "Massachusetts", "New Hamphshire" };
            img = new string[] { "massachusetts1_thumb", "new_hampshire1_thumb" };
            pictureBox1.Image = null;
            statesComboBox.Items.AddRange(states);

           /* PopupMenu.BackColor = Color.OrangeRed;
            PopupMenu.ForeColor = Color.Black;
            PopupMenu.Text = "States Menu";
            PopupMenu.Font = new Font("Segoe UI", 12);
            PopupMenu.Show();
			*/
        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = statesComboBox.SelectedItem.ToString();
            displayStatelabel.Text = item;

            statesListBox.Items.Add(statesComboBox.SelectedItem);
            statesListBox.SelectedItem = item;

            statesComboBox.Items.RemoveAt(statesComboBox.SelectedIndex);

            if (statesComboBox.Items.Count == 0)
            {
                MessageBox.Show("There are no more states in the " +
                    "ComboBox.", "Empty", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void statesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (statesListBox.SelectedIndex >= 0)
			{
				IsItemSelected = true;
				putBackStripMenuItem.Enabled = true;
				deleteToolStripMenuItem.Enabled = true;
				string item = statesListBox.SelectedItem.ToString();
				displayStatelabel.Text = item;

				string tempStr = GetResourceString(item);
				pictureBox1.Image = (Image)
					(Properties.Resources.ResourceManager.GetObject(tempStr));
			}
			else
			{
				IsItemSelected = false;
				putBackStripMenuItem.Enabled = false;
				deleteToolStripMenuItem.Enabled = false;
				pictureBox1.Image = null;
				displayStatelabel.Text = string.Empty;
			}

        }

        private void putBackStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = statesListBox.SelectedIndex;
            if (idx >= 0)
            {
                string item = statesListBox.SelectedItem.ToString();
                statesListBox.Items.Remove(item);
                statesComboBox.Items.Add(item);
            }
        }

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int idx = statesListBox.SelectedIndex;
			if (idx >= 0)
			{
				statesListBox.Items.RemoveAt(idx);
			}
		} // end method 

		private string GetResourceString(string name)
		{
			string newStr = name.Substring(5);
			foreach (var str in img)
			{
				if (str.Contains(newStr))
					return str;
			}
			return null;
		}

		private void statesListBox_DoubleClick(object sender, EventArgs e)
		{
			int idx = statesListBox.SelectedIndex;
			string item = statesListBox.SelectedItem.ToString();
			statesListBox.Items.Remove(item);
			statesComboBox.Items.Add(item);
		}
	}
}
