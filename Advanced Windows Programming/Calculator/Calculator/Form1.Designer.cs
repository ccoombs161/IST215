namespace Calculator
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.ButtonEq = new System.Windows.Forms.Button();
            this.ButtonRParen = new System.Windows.Forms.Button();
            this.ButtonLParen = new System.Windows.Forms.Button();
            this.ButtonClearEntry = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonMult = new System.Windows.Forms.Button();
            this.ButtonSub = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 12);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(190, 46);
            this.TextBox1.TabIndex = 12;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button3);
            this.Panel1.Controls.Add(this.Button6);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.Button4);
            this.Panel1.Controls.Add(this.Button8);
            this.Panel1.Controls.Add(this.Button9);
            this.Panel1.Controls.Add(this.Button13);
            this.Panel1.Controls.Add(this.Button7);
            this.Panel1.Controls.Add(this.Button0);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(12, 64);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(90, 120);
            this.Panel1.TabIndex = 13;
            // 
            // Panel2
            // 
            this.Panel2.AutoScroll = true;
            this.Panel2.AutoSize = true;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Location = new System.Drawing.Point(108, 64);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(34, 120);
            this.Panel2.TabIndex = 14;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ButtonEq);
            this.Panel3.Controls.Add(this.ButtonRParen);
            this.Panel3.Controls.Add(this.ButtonLParen);
            this.Panel3.Controls.Add(this.ButtonClearEntry);
            this.Panel3.Controls.Add(this.ButtonClear);
            this.Panel3.Location = new System.Drawing.Point(148, 64);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(54, 120);
            this.Panel3.TabIndex = 15;
            // 
            // ButtonEq
            // 
            this.ButtonEq.Location = new System.Drawing.Point(3, 90);
            this.ButtonEq.Name = "ButtonEq";
            this.ButtonEq.Size = new System.Drawing.Size(44, 23);
            this.ButtonEq.TabIndex = 6;
            this.ButtonEq.Text = "=";
            this.ButtonEq.UseVisualStyleBackColor = true;
            this.ButtonEq.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // ButtonRParen
            // 
            this.ButtonRParen.Location = new System.Drawing.Point(27, 61);
            this.ButtonRParen.Name = "ButtonRParen";
            this.ButtonRParen.Size = new System.Drawing.Size(22, 23);
            this.ButtonRParen.TabIndex = 8;
            this.ButtonRParen.Text = ")";
            this.ButtonRParen.UseVisualStyleBackColor = true;
            this.ButtonRParen.Click += new System.EventHandler(this.ButtonRParen_Click);
            // 
            // ButtonLParen
            // 
            this.ButtonLParen.Location = new System.Drawing.Point(3, 61);
            this.ButtonLParen.Name = "ButtonLParen";
            this.ButtonLParen.Size = new System.Drawing.Size(22, 23);
            this.ButtonLParen.TabIndex = 7;
            this.ButtonLParen.Text = "(";
            this.ButtonLParen.UseVisualStyleBackColor = true;
            this.ButtonLParen.Click += new System.EventHandler(this.ButtonLParen_Click);
            // 
            // ButtonClearEntry
            // 
            this.ButtonClearEntry.Location = new System.Drawing.Point(3, 32);
            this.ButtonClearEntry.Name = "ButtonClearEntry";
            this.ButtonClearEntry.Size = new System.Drawing.Size(44, 23);
            this.ButtonClearEntry.TabIndex = 5;
            this.ButtonClearEntry.Text = "C /A";
            this.ButtonClearEntry.UseCompatibleTextRendering = true;
            this.ButtonClearEntry.UseVisualStyleBackColor = true;
            this.ButtonClearEntry.Click += new System.EventHandler(this.ButtonClearEntry_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(3, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(44, 23);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ButtonDiv);
            this.panel4.Controls.Add(this.ButtonMult);
            this.panel4.Controls.Add(this.ButtonSub);
            this.panel4.Controls.Add(this.ButtonAdd);
            this.panel4.Location = new System.Drawing.Point(108, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 120);
            this.panel4.TabIndex = 0;
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(3, 90);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(23, 23);
            this.ButtonDiv.TabIndex = 5;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // ButtonMult
            // 
            this.ButtonMult.Location = new System.Drawing.Point(3, 3);
            this.ButtonMult.Name = "ButtonMult";
            this.ButtonMult.Size = new System.Drawing.Size(23, 23);
            this.ButtonMult.TabIndex = 4;
            this.ButtonMult.Text = "*";
            this.ButtonMult.UseVisualStyleBackColor = true;
            this.ButtonMult.Click += new System.EventHandler(this.ButtonMult_Click);
            // 
            // ButtonSub
            // 
            this.ButtonSub.Location = new System.Drawing.Point(3, 61);
            this.ButtonSub.Name = "ButtonSub";
            this.ButtonSub.Size = new System.Drawing.Size(23, 23);
            this.ButtonSub.TabIndex = 3;
            this.ButtonSub.Text = "-";
            this.ButtonSub.UseVisualStyleBackColor = true;
            this.ButtonSub.Click += new System.EventHandler(this.ButtonSub_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(3, 32);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(23, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(3, 90);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(52, 23);
            this.Button0.TabIndex = 9;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(4, 3);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(23, 23);
            this.Button7.TabIndex = 6;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button13
            // 
            this.Button13.Location = new System.Drawing.Point(61, 91);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(23, 23);
            this.Button13.TabIndex = 2;
            this.Button13.Text = ".";
            this.Button13.UseVisualStyleBackColor = true;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(62, 3);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(23, 23);
            this.Button9.TabIndex = 8;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(33, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(23, 23);
            this.Button8.TabIndex = 7;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(3, 32);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(23, 23);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(32, 32);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(23, 23);
            this.Button5.TabIndex = 4;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(61, 32);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(23, 23);
            this.Button6.TabIndex = 5;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(62, 61);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(23, 23);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(33, 61);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(23, 23);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(3, 61);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(23, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonClearEntry;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonRParen;
        private System.Windows.Forms.Button ButtonLParen;
        private System.Windows.Forms.Button ButtonEq;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSub;
        private System.Windows.Forms.Button ButtonMult;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button Button13;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
    }
}

