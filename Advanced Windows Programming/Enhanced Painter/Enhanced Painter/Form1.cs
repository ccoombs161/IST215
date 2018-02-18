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

		// draw circle when mouse moves w/ button down
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (ShouldPaint)
			{
				using (Graphics graphics = CreateGraphics())
				{
					graphics.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
				}
			}
		}

	}
}
