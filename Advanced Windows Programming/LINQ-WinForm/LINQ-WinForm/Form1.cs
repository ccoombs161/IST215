using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int lowvalue = Convert.ToInt32(textBox1.Text);
            int highvalue = Convert.ToInt32(textBox2.Text);
            //var employees = Employee(richTextBox1.Text);
            
            // richTextBox1.Text = Employee();
        }
    }
}
