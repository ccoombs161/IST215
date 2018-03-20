namespace ListBox
{
    partial class frmEmployee
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.lstAll = new System.Windows.Forms.ListBox();
            this.grpFiltered = new System.Windows.Forms.GroupBox();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.grpAll.SuspendLayout();
            this.grpFiltered.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(1, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(42, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From: $";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(115, 9);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To: $";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(49, 6);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(60, 20);
            this.txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(153, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(60, 20);
            this.txtTo.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.Enter += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpAll
            // 
            this.grpAll.Controls.Add(this.lstAll);
            this.grpAll.Location = new System.Drawing.Point(4, 46);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(209, 218);
            this.grpAll.TabIndex = 5;
            this.grpAll.TabStop = false;
            this.grpAll.Text = "Display All Employees";
            // 
            // lstAll
            // 
            this.lstAll.FormattingEnabled = true;
            this.lstAll.Location = new System.Drawing.Point(0, 19);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(203, 199);
            this.lstAll.TabIndex = 0;
            // 
            // grpFiltered
            // 
            this.grpFiltered.Controls.Add(this.lstSelected);
            this.grpFiltered.Location = new System.Drawing.Point(226, 46);
            this.grpFiltered.Name = "grpFiltered";
            this.grpFiltered.Size = new System.Drawing.Size(209, 218);
            this.grpFiltered.TabIndex = 6;
            this.grpFiltered.TabStop = false;
            this.grpFiltered.Text = "Selected Employees";
            // 
            // lstSelected
            // 
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.Location = new System.Drawing.Point(6, 19);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(203, 199);
            this.lstSelected.TabIndex = 0;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 336);
            this.Controls.Add(this.grpFiltered);
            this.Controls.Add(this.grpAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "frmEmployee";
            this.Text = "Employee List";
            this.grpAll.ResumeLayout(false);
            this.grpFiltered.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.GroupBox grpFiltered;
        private System.Windows.Forms.ListBox lstAll;
        private System.Windows.Forms.ListBox lstSelected;
    }
}

