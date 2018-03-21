using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_DeleteMe
{
    public partial class Form1 : Form
    {
        // Opens BankCustomer table in 2609 database on localhost
        private SqlDataAdapter customerDA;

        // Contains BankCustomer table
        private DataSet customerDS;
        private DataTable cTable;
        
        public Form1()
        {
            InitializeComponent();
            customerDS = new DataSet();
            ReadCustomerTable();
            //cTable = customerDS.Tables["BankCustomers"];

            //	string s = "Read " + customerDS.Tables["Customers"].Rows.Count.ToString() + " records";
            //	MessageBox.Show(s);

            //dataGridView1.DataSource = cTable;

        }

        private void ReadCustomerTable()
        {
            string connectString = @"data source=localhost;initial catalog=TestCustomer;integrated security=sspi";
            string commandString = @"SELECT * FROM BankCustomers";

            // note this creates a new data adapter
            // any old one is no longer referenced and will be garbage collected
            customerDA = new SqlDataAdapter(commandString, connectString);
            
            //Fill dataset with whatever is in DataAdaptor
            customerDA.Fill(customerDS, "BankCustomers");

            //Take the "BankCustomers" from Dataset and put it in the DataTable.
            cTable = customerDS.Tables["BankCustomers"];

            string s = "Read " + customerDS.Tables["BankCustomers"].Rows.Count.ToString() + " records";
            MessageBox.Show(s);
            
            //Make DataGrid views data source = DataTable
            dataGridView1.DataSource = cTable;
            //SqlCommandBuilder scb = new SqlCommandBuilder(customerDA);

            for (int i = 0; i < customerDS.Tables["BankCustomers"].Rows.Count; i++)
            {
                DataRow r = cTable.Rows[i];
                // Pull data from that row
                String s1 = r["CustomerName"].ToString();
                String s2 = r["CustomerAddress"].ToString();
                String s3 = r["CustomerPhone"].ToString();
                String s4 = r["Password"].ToString();
                Console.WriteLine("{0} {0} {0} {0} ", s1, s2, s3, s4);
                string s5 = s1 + "\r\n" + s2 + "\r\n" + s3 + "\r\n" + s4;
                MessageBox.Show(s5);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testCustomerDataSet.BankCustomers' table. You can move, or remove it, as needed.
            this.bankCustomersTableAdapter.Fill(this.testCustomerDataSet.BankCustomers);

        }
    }
}
