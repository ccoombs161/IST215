namespace States
{
    partial class StatesForm
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
            this.statesListBox = new System.Windows.Forms.ListBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.displayStatelabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.putBackStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statesListBox
            // 
            this.statesListBox.FormattingEnabled = true;
            this.statesListBox.Location = new System.Drawing.Point(12, 82);
            this.statesListBox.Name = "statesListBox";
            this.statesListBox.Size = new System.Drawing.Size(120, 121);
            this.statesListBox.TabIndex = 0;
            this.statesListBox.SelectedIndexChanged += new System.EventHandler(this.statesListBox_SelectedIndexChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(21, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(80, 13);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Select a State: ";
            // 
            // statesComboBox
            // 
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(12, 43);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(121, 21);
            this.statesComboBox.TabIndex = 2;
            // 
            // displayStatelabel
            // 
            this.displayStatelabel.AutoSize = true;
            this.displayStatelabel.Location = new System.Drawing.Point(155, 82);
            this.displayStatelabel.Name = "displayStatelabel";
            this.displayStatelabel.Size = new System.Drawing.Size(86, 13);
            this.displayStatelabel.TabIndex = 3;
            this.displayStatelabel.Text = "displayStatelabel";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.putBackStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // putBackStripMenuItem
            // 
            this.putBackStripMenuItem.Name = "putBackStripMenuItem";
            this.putBackStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.putBackStripMenuItem.Text = "Put It Back";
            this.putBackStripMenuItem.Click += new System.EventHandler(this.putBackStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(158, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayStatelabel);
            this.Controls.Add(this.statesComboBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.statesListBox);
            this.Name = "StatesForm";
            this.Text = "States";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox statesListBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ComboBox statesComboBox;
        private System.Windows.Forms.Label displayStatelabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem putBackStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

