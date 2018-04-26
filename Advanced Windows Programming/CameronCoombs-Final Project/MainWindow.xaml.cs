﻿using System;
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



namespace CameronCoombs_Final_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CUSTOMER_ORDEREntities1 db = new CUSTOMER_ORDEREntities1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var custData1
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
            //dataGrid1.ItemsSource = custData1.ToList();
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
	}
}
