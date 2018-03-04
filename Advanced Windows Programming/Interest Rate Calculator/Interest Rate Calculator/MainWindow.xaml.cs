using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interest_Rate_Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			txtPrincipal.Focus();
		}
		private void btnCalculate_Click(object sender, RoutedEventArgs e)
		{
			decimal amount = 0M;
			decimal principal = 0M;
			double interestRate = 0;
			int years = 0;
			int nTimesComputed = 0;

			years = Convert.ToInt32(txtYears.Text);
			interestRate = Convert.ToDouble(txtInterest.Text);
			principal = Convert.ToDecimal(txtPrincipal.Text);
			amount = Convert.ToDecimal(txtPrincipal.Text);

			if (rdoMonthly.IsChecked == true)
				nTimesComputed = 12;
			else if (rdoQuarterly.IsChecked == true)
				nTimesComputed = 4;
			else if (rdoSemiAnnually.IsChecked == true)
				nTimesComputed = 2;
			else
				nTimesComputed = 1;

			amount = principal * (decimal)Math.Pow((1 + ((interestRate / 100) / nTimesComputed)), (nTimesComputed * years));

			txtCurrentValue.Text = amount.ToString("C");
			decimal interestEarned = amount - principal;
			txtInterestEarned.Text = interestEarned.ToString("C");
			txtPrincipal.SelectAll();
			txtPrincipal.Focus();
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
