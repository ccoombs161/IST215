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

namespace AcmeCustomerData
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		CUSTOMER_ORDEREntities db = new CUSTOMER_ORDEREntities();

		private string address;
		private string email;
		private string firstName;
		private string lastName;
		public string Phone { get; set; }
		public int AddressID { get; set; }
		private static int count = 0;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var query1 = from c in db.CUSTOMERs
						 join o in db.ORDERs on
						 c.CustomerID equals o.CustomerID
						 select new
						 {
							 c.CustomerID,
							 CustomerName = c.CustomerName.Trim(),
							 c.City,
							 c.State,
							 o.OrderNum,
							 ProductNumber = o.ProductNumber.Trim(),
							 o.ProductType,
							 o.ProductName
						 };
			dataGrid1.ItemsSource = query1.ToList();
		}

		private void btn_Next_Click_1(object sender, RoutedEventArgs e)
		{

		}

		private void btn_first_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Last_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Previous_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Connect_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Create_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Exit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
		
			

			/*public Person()
			{
				count++;
				AddressID = count;
			}

			public Person(string first, string last, string add, string email, string phone)
			{
				count++;
				FirstName = first;
				LastName = last;
				Address = add;
				Email = email;
				Phone = phone;
			}
			*/
			public string LastName
			{
				get
				{
					return lastName;
				}
				set
				{
					lastName = value;
				}
			}

			public string FirstName
			{
				get
				{
					return firstName;
				}
				set
				{
					firstName = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set
				{
					address = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set
				{
					email = value;
				}
			}
	}
	}

