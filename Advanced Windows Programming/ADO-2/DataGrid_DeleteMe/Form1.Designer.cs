namespace DataGrid_DeleteMe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bankCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testCustomerDataSet = new DataGrid_DeleteMe.TestCustomerDataSet();
            this.bankCustomersTableAdapter = new DataGrid_DeleteMe.TestCustomerDataSetTableAdapters.BankCustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCustomerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // bankCustomersBindingSource
            // 
            this.bankCustomersBindingSource.DataMember = "BankCustomers";
            this.bankCustomersBindingSource.DataSource = this.testCustomerDataSet;
            // 
            // testCustomerDataSet
            // 
            this.testCustomerDataSet.DataSetName = "TestCustomerDataSet";
            this.testCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankCustomersTableAdapter
            // 
            this.bankCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 295);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCustomerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TestCustomerDataSet testCustomerDataSet;
        private System.Windows.Forms.BindingSource bankCustomersBindingSource;
        private TestCustomerDataSetTableAdapters.BankCustomersTableAdapter bankCustomersTableAdapter;
    }
}

