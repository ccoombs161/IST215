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

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source=.;uid=sa;pwd=BadDog99;database=CUSTOMER_ORDER");
            // string sConnectionString = "Data Source=localhost;Initial Catalog=CUSTOMER_ORDER;Integrated Security=True";
            string sCmd = @"SELECT * FROM CUSTOMER";
            // SqlConnection conn = new SqlConnection(sConnectionString);
            DataSet dsCutomer = new DataSet();
            SqlDataAdapter daCustomer = new SqlDataAdapter(sCmd, conn);   //4 overloads: 1) def, 2) cmd,  3) cmdStr, conn, cmdStr, conStr

            /* Fill the dataSet. In here we did not provide a name to the table
             * Therefore you have to access table with an index
             */
            // daCustomer.Fill(dsCutomer);
            // DataTable tblCustomer = dsCutomer.Tables[0];  // get the first table.

            daCustomer.Fill(dsCutomer, "Customer");
            DataTable tblCustomer = dsCutomer.Tables["CUSTOMER"];
            dataGridView1.DataSource = dsCutomer.Tables["Customer"];
        }
    }
}
