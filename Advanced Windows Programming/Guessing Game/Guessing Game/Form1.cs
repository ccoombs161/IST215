using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
	public partial class Form1 : Form
	{

		// Declare Random Number 
		Random number = new Random();
		int Number;
		int numOfGuesses = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Number = number.Next(0, 1000);
					
		}	

		private void btnNewGame_Click(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{

		}

		
	}
}
