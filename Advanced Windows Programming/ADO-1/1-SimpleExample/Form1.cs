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

namespace _1_SimpleExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillData();
        } // end constructor

        void FillData()
        {
            // Create a connection Open connection
            using (SqlConnection conn = new SqlConnection(
            "Data Source=.;Initial Catalog=AddressBook;Integrated Security=True"))
                // Properties.Settings.Default.ConnectionString))
            {
                conn.Open();    // Open connection

                // Create a DataAdapter. Pass it command and conn objects.
                using (SqlDataAdapter a = new SqlDataAdapter(
                    "SELECT * FROM dbo.Addresses", conn))
                {
                    // Use DataAdapter to fill a DataTable
                    DataTable tbl = new DataTable();
                    a.Fill(tbl);

                    // Make the table as the source of DataGridView control.
                    dataGridView1.DataSource = tbl; 
                }
            }
        }

    }
}
