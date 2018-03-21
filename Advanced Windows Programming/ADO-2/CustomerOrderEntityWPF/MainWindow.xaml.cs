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

namespace CustomerOrderEntity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CUSTOMER_ORDEREntities dataEntities = new CUSTOMER_ORDEREntities();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            //dataGrid1.ItemsSource = dataEntities.CUSTOMERs
            //    .Include("Orders")
            //    .Select(p => new { p.CustomerID, p.CustomerName, p.City, p.EmailDomain, p.ORDERs })
            //    .ToList();
            dataGrid1.ItemsSource = (from customers in dataEntities.CUSTOMERs
                                    join orders in dataEntities.ORDERs on 
                                    customers.CustomerID equals orders.CustomerID
                                    select new {customers.CustomerName, orders.OrderNum, orders.ProductName })
                                    .ToList();
            //var query = dataEntities.CUSTOMERs.Include("ORDER").First(s ==> s.);
        }
    }
}
