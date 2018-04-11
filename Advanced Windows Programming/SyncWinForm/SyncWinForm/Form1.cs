using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           // label1.BackColor = Color.Black;
            label1.ForeColor = Color.Red;
            label1.Text = "Task Started\r\n";
            Application.DoEvents();

           await DoWork();
            label1.Text = "\r\nTask Completed";

            //DO Work
        }

        private async Task DoWork()
        {
            await Task.Delay(5000);
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // label1.BackColor = Color.Black;
            label2.ForeColor = Color.Red;
            label2.Text = "Task Started\r\n";
            Application.DoEvents();

            await DoWork();
            label2.Text = "\r\nTask Completed";

            //DO Work
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // label1.BackColor = Color.Black;
            label3.ForeColor = Color.Red;
            label3.Text = "Task Started\r\n";
            Application.DoEvents();

            await DoWork();
            label3.Text = "\r\nTask Completed";

            //DO Work
        }
    }
}
