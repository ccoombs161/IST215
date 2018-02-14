namespace InterestRateCalculator
{
    partial class frmInterestCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterestCalculator));
            this.txtPrincipalAmount = new System.Windows.Forms.TextBox();
            this.principalLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.nudInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrincipalAmount
            // 
            this.txtPrincipalAmount.Location = new System.Drawing.Point(93, 12);
            this.txtPrincipalAmount.Name = "txtPrincipalAmount";
            this.txtPrincipalAmount.Size = new System.Drawing.Size(119, 20);
            this.txtPrincipalAmount.TabIndex = 0;
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(15, 52);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(50, 13);
            this.principalLabel.TabIndex = 9;
            this.principalLabel.Text = "Principal:";
            // 
            // interestLabel
            // 
            this.interestLabel.Location = new System.Drawing.Point(12, 13);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(72, 19);
            this.interestLabel.TabIndex = 11;
            this.interestLabel.Text = "Interest rate:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(221, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 26);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(221, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 26);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(28, 82);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(37, 13);
            this.yearsLabel.TabIndex = 13;
            this.yearsLabel.Text = "Years:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDisplay.Location = new System.Drawing.Point(12, 123);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(296, 119);
            this.txtDisplay.TabIndex = 16;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 105);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(122, 13);
            this.balanceLabel.TabIndex = 15;
            this.balanceLabel.Text = "Yearly account balance:";
            // 
            // nudInterestRate
            // 
            this.nudInterestRate.Location = new System.Drawing.Point(92, 43);
            this.nudInterestRate.Name = "nudInterestRate";
            this.nudInterestRate.Size = new System.Drawing.Size(120, 20);
            this.nudInterestRate.TabIndex = 19;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(93, 82);
            this.nudYear.Name = "nudYear";
            this.nudYear.ReadOnly = true;
            this.nudYear.Size = new System.Drawing.Size(120, 20);
            this.nudYear.TabIndex = 2;
            // 
            // frmInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudInterestRate);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.txtPrincipalAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInterestCalculator";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrincipalAmount;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.NumericUpDown nudInterestRate;
        private System.Windows.Forms.NumericUpDown nudYear;
    }
}

