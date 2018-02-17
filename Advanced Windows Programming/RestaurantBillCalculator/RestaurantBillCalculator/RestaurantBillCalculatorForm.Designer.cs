namespace RestaurantBillCalculator
{
	partial class RestaurantBillCalculatorForm
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
			this.beverageComboBox = new System.Windows.Forms.ComboBox();
			this.appetizerComboBox = new System.Windows.Forms.ComboBox();
			this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
			this.dessertComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblTax = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblRestaurantName = new System.Windows.Forms.Label();
			this.nudTip = new System.Windows.Forms.NumericUpDown();
			this.rtxtOutput = new System.Windows.Forms.RichTextBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.totalButton = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.lblTipValue = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTip)).BeginInit();
			this.SuspendLayout();
			// 
			// beverageComboBox
			// 
			this.beverageComboBox.FormattingEnabled = true;
			this.beverageComboBox.Location = new System.Drawing.Point(101, 21);
			this.beverageComboBox.Name = "beverageComboBox";
			this.beverageComboBox.Size = new System.Drawing.Size(121, 24);
			this.beverageComboBox.TabIndex = 0;
			// 
			// appetizerComboBox
			// 
			this.appetizerComboBox.FormattingEnabled = true;
			this.appetizerComboBox.Location = new System.Drawing.Point(101, 54);
			this.appetizerComboBox.Name = "appetizerComboBox";
			this.appetizerComboBox.Size = new System.Drawing.Size(121, 24);
			this.appetizerComboBox.TabIndex = 1;
			// 
			// mainCourseComboBox
			// 
			this.mainCourseComboBox.FormattingEnabled = true;
			this.mainCourseComboBox.Location = new System.Drawing.Point(101, 83);
			this.mainCourseComboBox.Name = "mainCourseComboBox";
			this.mainCourseComboBox.Size = new System.Drawing.Size(121, 24);
			this.mainCourseComboBox.TabIndex = 2;
			// 
			// dessertComboBox
			// 
			this.dessertComboBox.FormattingEnabled = true;
			this.dessertComboBox.Location = new System.Drawing.Point(101, 113);
			this.dessertComboBox.Name = "dessertComboBox";
			this.dessertComboBox.Size = new System.Drawing.Size(121, 24);
			this.dessertComboBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Beverage:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Appetizer:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Main course:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Dessert:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dessertComboBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.mainCourseComboBox);
			this.groupBox1.Controls.Add(this.beverageComboBox);
			this.groupBox1.Controls.Add(this.appetizerComboBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(21, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 173);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu Items";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Location = new System.Drawing.Point(419, 58);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(297, 111);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Waiter Information";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(110, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Waiter\'s name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(110, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "Table number:";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AutoSize = true;
			this.lblSubTotal.Location = new System.Drawing.Point(460, 290);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(64, 17);
			this.lblSubTotal.TabIndex = 4;
			this.lblSubTotal.Text = "Subtotal:";
			// 
			// lblTax
			// 
			this.lblTax.AutoSize = true;
			this.lblTax.Location = new System.Drawing.Point(460, 324);
			this.lblTax.Name = "lblTax";
			this.lblTax.Size = new System.Drawing.Size(35, 17);
			this.lblTax.TabIndex = 10;
			this.lblTax.Text = "Tax:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(460, 357);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(44, 17);
			this.lblTotal.TabIndex = 11;
			this.lblTotal.Text = "Total:";
			// 
			// lblRestaurantName
			// 
			this.lblRestaurantName.AutoSize = true;
			this.lblRestaurantName.Location = new System.Drawing.Point(329, 9);
			this.lblRestaurantName.Name = "lblRestaurantName";
			this.lblRestaurantName.Size = new System.Drawing.Size(142, 17);
			this.lblRestaurantName.TabIndex = 4;
			this.lblRestaurantName.Text = "Roadside Restaurant";
			// 
			// nudTip
			// 
			this.nudTip.Location = new System.Drawing.Point(729, 355);
			this.nudTip.Name = "nudTip";
			this.nudTip.Size = new System.Drawing.Size(42, 22);
			this.nudTip.TabIndex = 12;
			// 
			// rtxtOutput
			// 
			this.rtxtOutput.Location = new System.Drawing.Point(21, 262);
			this.rtxtOutput.Name = "rtxtOutput";
			this.rtxtOutput.Size = new System.Drawing.Size(273, 200);
			this.rtxtOutput.TabIndex = 13;
			this.rtxtOutput.Text = "";
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(419, 414);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 8;
			this.clearButton.Text = "Clear Bill";
			this.clearButton.UseVisualStyleBackColor = true;
			// 
			// totalButton
			// 
			this.totalButton.Location = new System.Drawing.Point(513, 414);
			this.totalButton.Name = "totalButton";
			this.totalButton.Size = new System.Drawing.Size(75, 23);
			this.totalButton.TabIndex = 14;
			this.totalButton.Text = "Total Bill";
			this.totalButton.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(530, 287);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 15;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(530, 319);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 16;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(530, 351);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 17;
			// 
			// lblTipValue
			// 
			this.lblTipValue.AutoSize = true;
			this.lblTipValue.Location = new System.Drawing.Point(682, 353);
			this.lblTipValue.Name = "lblTipValue";
			this.lblTipValue.Size = new System.Drawing.Size(32, 17);
			this.lblTipValue.TabIndex = 18;
			this.lblTipValue.Text = "Tip:";
			// 
			// RestaurantBillCalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 488);
			this.Controls.Add(this.lblTipValue);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.totalButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.rtxtOutput);
			this.Controls.Add(this.nudTip);
			this.Controls.Add(this.lblRestaurantName);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblTax);
			this.Controls.Add(this.lblSubTotal);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "RestaurantBillCalculatorForm";
			this.Text = "Restaurant Bill Calculator";
			this.Load += new System.EventHandler(this.RestaurantBillCalculatorForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTip)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox beverageComboBox;
		private System.Windows.Forms.ComboBox appetizerComboBox;
		private System.Windows.Forms.ComboBox mainCourseComboBox;
		private System.Windows.Forms.ComboBox dessertComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblSubTotal;
		private System.Windows.Forms.Label lblTax;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblRestaurantName;
		private System.Windows.Forms.NumericUpDown nudTip;
		private System.Windows.Forms.RichTextBox rtxtOutput;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button totalButton;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label lblTipValue;
	}
}

