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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClearEntry = new System.Windows.Forms.Button();
            this.ButtonLParen = new System.Windows.Forms.Button();
            this.ButtonRParen = new System.Windows.Forms.Button();
            this.ButtonEq = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSub = new System.Windows.Forms.Button();
            this.ButtonMult = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
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
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(3, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(44, 23);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
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
            // 
            // ButtonLParen
            // 
            this.ButtonLParen.Location = new System.Drawing.Point(3, 61);
            this.ButtonLParen.Name = "ButtonLParen";
            this.ButtonLParen.Size = new System.Drawing.Size(22, 23);
            this.ButtonLParen.TabIndex = 7;
            this.ButtonLParen.Text = "(";
            this.ButtonLParen.UseVisualStyleBackColor = true;
            // 
            // ButtonRParen
            // 
            this.ButtonRParen.Location = new System.Drawing.Point(27, 61);
            this.ButtonRParen.Name = "ButtonRParen";
            this.ButtonRParen.Size = new System.Drawing.Size(22, 23);
            this.ButtonRParen.TabIndex = 8;
            this.ButtonRParen.Text = ")";
            this.ButtonRParen.UseVisualStyleBackColor = true;
            // 
            // ButtonEq
            // 
            this.ButtonEq.Location = new System.Drawing.Point(3, 90);
            this.ButtonEq.Name = "ButtonEq";
            this.ButtonEq.Size = new System.Drawing.Size(44, 23);
            this.ButtonEq.TabIndex = 6;
            this.ButtonEq.Text = "=";
            this.ButtonEq.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(3, 32);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(23, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonSub
            // 
            this.ButtonSub.Location = new System.Drawing.Point(3, 61);
            this.ButtonSub.Name = "ButtonSub";
            this.ButtonSub.Size = new System.Drawing.Size(23, 23);
            this.ButtonSub.TabIndex = 3;
            this.ButtonSub.Text = "-";
            this.ButtonSub.UseVisualStyleBackColor = true;
            // 
            // ButtonMult
            // 
            this.ButtonMult.Location = new System.Drawing.Point(3, 3);
            this.ButtonMult.Name = "ButtonMult";
            this.ButtonMult.Size = new System.Drawing.Size(23, 23);
            this.ButtonMult.TabIndex = 4;
            this.ButtonMult.Text = "*";
            this.ButtonMult.UseVisualStyleBackColor = true;
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(3, 90);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(23, 23);
            this.ButtonDiv.TabIndex = 5;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
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
    }
}

