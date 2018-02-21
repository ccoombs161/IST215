using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enhanced_Painter
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false; // determines whether to paint
        Color color = Color.Red;
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        bool ShouldPaint { get; set; } = false;

        // should paint when mouse pressed
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        // stop painting
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;

        }

        private void rad_Click(object sender, EventArgs e)
        {
            ValidateColor();
            ValidateSize();
        }
        // draw circle when mouse moves w/ button down
        private void Form1_MouseMove(
          object sender, MouseEventArgs e)
        {
            Graphics graphics = label1.CreateGraphics();
            if (shouldPaint)
            {
                using (graphics)
                {
                    graphics.FillEllipse(
                       new SolidBrush(color), e.X, e.Y, x, x);
                }
            }
        } // end method Painter_MouseMove

        private void ValidateSize()
        {
            if (smallbtn.Checked)
            {
                x = 5;
            }
            else if (mediumbtn.Checked)
            {
                x = 10;
            }
            else
            {
                x = 15;
            }
        }

        private void ValidateColor()
        {
            if (redbtn.Checked)
            {
                color = Color.Red;
            }
            else if (bluebtn.Checked)
            {
                color = Color.Blue;
            }
            else if (greenbtn.Checked)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Black;
            }

        }
    }
}
