namespace cw_1
{
    partial class frmMain
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
            System.Windows.Forms.Button btnDisplay;
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtEnterText = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new System.Drawing.Point(49, 162);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new System.Drawing.Size(87, 27);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(170, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEnterText
            // 
            this.lblEnterText.Location = new System.Drawing.Point(46, 68);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(117, 27);
            this.lblEnterText.TabIndex = 2;
            this.lblEnterText.Text = "Enter Text";
            // 
            // txtEnterText
            // 
            this.txtEnterText.Location = new System.Drawing.Point(170, 65);
            this.txtEnterText.Name = "txtEnterText";
            this.txtEnterText.Size = new System.Drawing.Size(116, 21);
            this.txtEnterText.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Aqua;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Location = new System.Drawing.Point(49, 219);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(209, 60);
            this.lbl.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AcceptButton = btnDisplay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtEnterText);
            this.Controls.Add(this.lblEnterText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(btnDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "My First Lab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.TextBox txtEnterText;
        private System.Windows.Forms.Label lbl;
    }
}

