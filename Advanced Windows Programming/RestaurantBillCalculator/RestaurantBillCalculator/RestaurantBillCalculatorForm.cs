using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
	public partial class RestaurantBillCalculatorForm : Form
	{
		// keep items running on bill
		private decimal subtotal = 0M;
		private decimal tip = 0M;
		private decimal tax = 0M;
		private string output;

		private static Dictionary<string, decimal> beverages = new
			Dictionary<string, decimal>
			{
				{ "None", 0.0m }, { "Soda", 1.95m}, {"Tea", 1.50m}, { "Coffee", 1.25m},
			{ "Mineral Water", 2.95m}, { "Juice", 2.50m}, { "Milk", 1.50m}
			};

		private static Dictionary<string, decimal> appetizers = new
			Dictionary<string, decimal>
			{
				{ "None", 0.0m }, { "Buffalo Wings", 5.95m}, {"Buffalo Fingers", 6.95m}, { "Potato Skins", 8.95m},
			{ "Nachos", 8.95m}, { "Mushroom Caps", 10.95m}, { "Shrimp Cocktail", 12.95m}, { "Chips and Salsa", 6.95m}
			};

		private static Dictionary<string, decimal> mainCourses = new
			Dictionary<string, decimal>
			{
				{ "None", 0.0m }, { "Seafood Alfredo", 13.95m}, {"Chicken Alfredo", 13.95m}, { "Chicken Picatta", 13.95m},
			{ "Turkey Club", 11.95m}, { "Lobster Pie", 19.95m}, { "Prime Rib", 20.95m}, { "Shrimp Scampi", 18.95m},
			{ "Turkey Dinner", 13.95m}, { "Stuffed Chicken", 14.95m}
			};

		private static Dictionary<string, decimal> desserts = new
			Dictionary<string, decimal>
			{
				{ "None", 0.0m }, { "Apple Pie", 5.95m}, {"Sundae", 3.95m}, { "Carrot Cake", 5.95m},
			{ "Mud Pie", 4.95m}, { "Apple Crisp", 5.95m}
			};

		public RestaurantBillCalculatorForm()
		{
			InitializeComponent();
			nudTip.Value = 15M; // default tip
		}

		private void RestaurantBillCalculatorForm_Load(object sender, EventArgs e)
		{ 
			// load ComboBox
			LoadCategory("Beverage", beverageComboBox);
			LoadCategory("Appetizer", appetizerComboBox);
			LoadCategory("Main Course", mainCourseComboBox);
			LoadCategory("Dessert", dessertComboBox);
		}

		public void LoadCategory(string categoryString, ComboBox categoryCombo)
		{
			List<string> items = null;

			switch (categoryString)
			{
				case "Beverage":
					items = beverages.Keys.ToList();
					break;
				case "Appetizer":
					items = appetizers.Keys.ToList();
					break;
				case "Main Course":
					items = mainCourses.Keys.ToList();
					break;
				default:
					items = desserts.Keys.ToList();
					break;
			} // end switch

			categoryCombo.Items.AddRange(items.ToArray());
		} // end LoadCategory

		// add selected beverage to subtototal
		private void beverageComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedItem = Convert.ToString(beverageComboBox.SelectedItem);
			output += selectedItem.Equals("None") ? "" : selectedItem;

			AddToSubtotal("Beverage", selectedItem);
			output += "\r\n";
			rtxtOutput.Text = output;
		}

		private void appetizerComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedItem = Convert.ToString(beverageComboBox.SelectedItem);
			output += selectedItem.Equals("None") ? "" : selectedItem;

			AddToSubtotal("Appetizer", selectedItem);
			output += "\r\n";
			rtxtOutput.Text = output;
		}

		private void mainCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedItem = Convert.ToString(beverageComboBox.SelectedItem);
			output += selectedItem.Equals("None") ? "" : selectedItem;

			AddToSubtotal("Main Course", selectedItem);
			output += "\r\n";
			rtxtOutput.Text = output;
		}

		private void dessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedItem = Convert.ToString(beverageComboBox.SelectedItem);
			output += selectedItem.Equals("None") ? "" : selectedItem;

			AddToSubtotal("Dessert", selectedItem);
			output += "\r\n";
			rtxtOutput.Text = output;
		}

		private void AddToSubtotal(string category, string name)
		{
			Dictionary<string, decimal> items = null;

			switch (category)
			{
				case "Beverage":
					items = beverages;
					break;
				case "Appetizer":
					items = appetizers;
					break;
				case "Main Course":
					items = mainCourses;
					break;
				default:
					items = desserts;
					break;
			}

			foreach (var item in items)
			{
				if (item.Key == name)
				{
					subtotal += item.Value;
				}
			}

			// display the Subtototal in Label
			lblSubTotal.Text = string.Format("{0:C}", subtotal);

			// calculate tax and display in label, NH meal tax is 9%
			tax = subtotal * 0.09M;
			tip = (nudTip.Value / 100) * (subtotal + tax);
			lblTax.Text = string.Format("{0:C}", tip);

			// calculate total and display in label
			lblTotal.Text = string.Format("{0:C}", (subtotal + tax + tip));
		} // end method AddToSubtotal

		private void clearButton_Click(object sender, EventArgs e)
		{
			// clear subtotal 
			subtotal = 0M;

			// clear outputs
			lblSubTotal.Text = "$0.00";
			lblTax.Text = "$0.00";
			lblTax.Text = "$0.00";
			lblTipValue.Text = "$0.00";

			rtxtOutput.Text = "";
			output = "";
		} // end method clearButton_Click

		private void nudTip_ValueChanged(object sender, EventArgs e)
		{
			ReCalculateTip();
		}

		private void ReCalculateTip()
		{
			tip = (nudTip.Value / 100) * (subtotal + tax);
			lblTipValue.Text = tip.ToString("C");
			lblTotal.Text = string.Format("{0:C}", (subtotal + tax + tip));
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	} // end class RestaurantBillCalculatorForm
} // end namespace RestaurantBillCalculator
