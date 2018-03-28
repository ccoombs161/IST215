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

            PopupMenu.BackColor = Color.OrangeRed;
            PopupMenu.ForeColor = Color.Black;
            PopupMenu.Text = "States Menu";
            PopupMenu.Font = new Font("Segoe UI", 12);
            PopupMenu.Show();

        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = statesComboBox.SelectedItem.ToString();
            displayStateLabel.Text = item;

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
    }
}
