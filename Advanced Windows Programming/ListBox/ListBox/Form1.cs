using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class frmEmployee : Form
    {
        static string strDisplayAll;
        static string strDisplayFiltered;

        private Employee[] allEmployees =
        {
            new Employee( "Jason", "Red", 5000M),
            new Employee( "Ashley", "Green", 7600M),
            new Employee( "Matthew", "Indigo", 3587.5M),
            new Employee( "James", "Indigo", 4700.77M),
            new Employee( "Luke", "Indigo", 6200M),
            new Employee( "Jason", "Blue", 1200M),
            new Employee( "Jacob", "Blue", 3200M),
            new Employee( "James", "Blue", 7200M),
            new Employee( "Wendy", "Brown", 4236.4M),
        };
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            lstAll.DataSource = allEmployees;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var filteredOutput =
                from emp in allEmployees
                where emp.MonthlySalary >= Convert.ToDecimal(txtTo.Text) &&
                    emp.MonthlySalary <= Convert.ToDecimal(txtFrom.Text)
                select emp;

            // select String.Format("{0:25} {1:25} {2:C}", emp.FirstName, emp.LastName, emp.MonthlySalary);

            lstSelected.DataSource = filteredOutput.ToArray();
           

        }
    }
}
