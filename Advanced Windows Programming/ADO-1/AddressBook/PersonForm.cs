using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonGUI
{
    public partial class PersonGUI : Form
    {
        Person person;
        List<Person> personList;
        int currentPerson;
        int count;
        DataSet ds = null;
        SqlConnection conn = null;
        SqlCommand cmdObject = null;
        SqlDataAdapter da = null;


        #region "Initialization Variables"
        //string used by form1 to get the table name
        public static string TableName = string.Empty;
        //string list used by form1 to get the column names
        public static List<string> ColumnNames = new List<string>();
        //string list used by form1 to get first columns name
        public static string firstColumnName;
        #endregion



        public PersonGUI()
        {
            InitializeComponent();
            currentPerson = 0;
            count = 0;
            personList = new List<Person>();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Address = txtAddress.Text;
            person.Email = txtEmail.Text;
            currentPerson++;
            count++;
            personList.Add(person);
            DataRow newRow = ds.Tables[0].NewRow();
            newRow[1] = txtFirstName.Text;
            newRow[2] = txtLastName.Text;
            newRow[3] = txtEmail.Text;
            newRow[4] = txtPhone.Text;
            ds.Tables[0].Rows.Add(newRow);
            ds.AcceptChanges();
            try
            {
                da.Update(ds.Tables[0]);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }


            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count > 0 && currentPerson < count - 1)
            {
                currentPerson++;
                SetValueTextboxes();
                //txtFirstName.Text = personList[currentPerson].FirstName;
                //txtLastName.Text = personList[currentPerson].LastName;
                //txtAddress.Text = personList[currentPerson].Address;
                //txtPhone.Text = personList[currentPerson].Email;
            }

        }

        private void SetValueTextboxes()
        {
            txtFirstName.Text = personList[currentPerson].FirstName;
            txtLastName.Text = personList[currentPerson].LastName;
            txtAddress.Text = personList[currentPerson].Address;
            txtPhone.Text = personList[currentPerson].Phone;
            txtEmail.Text = personList[currentPerson].Email;
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                currentPerson = 0;
                SetValueTextboxes();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (count > 0 && currentPerson > 0)
            {
                currentPerson--;
                SetValueTextboxes();
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                currentPerson = count - 1;
                SetValueTextboxes();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /* 
             * In order to communicate with a database, you must first establish a connection with that database.
             * For SQL Server, you can use SQLConnection class, for generic connection use OleDbConnection.
             * Once you have instantiated a connection object, that object is used to issue commands to the
             * database via an SqlCommand (or OleDbCommand) object. You can also use the Connection object to
             * read the content of the database through an Sql or OleDbReader object.
             * I am using SQL Connection Object to connect to SQL Server database.
             */
  
            try
            {
                conn = new SqlConnection();     // 1 - Instantiate a Connection Object
                
                cmdObject = new SqlCommand();   // 2 - Instantiate a Command Object
                conn.ConnectionString = "Data Source=.;Initial Catalog=AddressBook;Integrated Security=True";

                //3 Set command string. set the sql commands command to select all from the [tablename]
                cmdObject.CommandText = "SELECT * FROM dbo.Addresses";

                cmdObject.Connection = conn;    // 4 Pass the connection information to sql commands
                
                //Create a DataSet to hold data in memory after we get data from the database
                ds = new DataSet();
                
                //object that will adapt the data learned from the sql command to be placed into the dataset
                da = new SqlDataAdapter();
                                
                //set the datapaters command = cmdObject. It will run the sql select statment to get all the data
                da.SelectCommand = cmdObject;
                
                //adapter object executes the select statemet to fill the dataset with its data                
                da.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int i = 0;
                    person = new Person();
                    i++; // skip AddressID field
                    person.FirstName = row[i++].ToString();
                    person.LastName = row[i++].ToString();
                    //person.Address = row[i++].ToString();
                    person.Email = row[i++].ToString();
                    person.Phone = row[i++].ToString();
                    
                    currentPerson++;
                    count++;
                    personList.Add(person);                    
                }
               
                //Sets the grids datasource to the first table in the dataset object, which has the sql data
                dataGridView1.DataSource = ds.Tables[0];
                
                // gets the name of the first column, used for form 1's delete method
                firstColumnName = dataGridView1.Columns[0].Name;
                
                //for all the columns in the girdview, starts at 0 do not skip first(id) column
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    string s = dataGridView1.Columns[i].Name;
                    //add s to the column name list
                    ColumnNames.Add(s);
                }

                txtFirstName.Text = personList[0].FirstName.ToString();
                txtLastName.Text = personList[0].LastName.ToString();

                //display the connected label
                lblConnectStatus.Visible = true;
                //set the connect labels text
                lblConnectStatus.Text = "Connected Succesfully";
            }
            //catch
            catch (Exception ex)
            {
                //display the connected label
                lblConnectStatus.Visible = true;
                lblConnectStatus.Text = "Connection Failed. Reason: \r\n" + ex.ToString();
            }
            finally
            {                
                conn.Close();
                cmdObject.Dispose();
            }
        }

    }
}
