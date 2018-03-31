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
			this.statesListBox.ItemHeight = 16;
			this.statesListBox.Location = new System.Drawing.Point(16, 101);
			this.statesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.statesListBox.Name = "statesListBox";
			this.statesListBox.Size = new System.Drawing.Size(159, 148);
			this.statesListBox.TabIndex = 0;
			this.statesListBox.SelectedIndexChanged += new System.EventHandler(this.statesListBox_SelectedIndexChanged);
			this.statesListBox.DoubleClick += new System.EventHandler(this.statesListBox_DoubleClick);
			// 
			// displayLabel
			// 
			this.displayLabel.AutoSize = true;
			this.displayLabel.Location = new System.Drawing.Point(28, 11);
			this.displayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.displayLabel.Name = "displayLabel";
			this.displayLabel.Size = new System.Drawing.Size(104, 17);
			this.displayLabel.TabIndex = 1;
			this.displayLabel.Text = "Select a State: ";
			// 
			// statesComboBox
			// 
			this.statesComboBox.FormattingEnabled = true;
			this.statesComboBox.Location = new System.Drawing.Point(16, 53);
			this.statesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.statesComboBox.Name = "statesComboBox";
			this.statesComboBox.Size = new System.Drawing.Size(160, 24);
			this.statesComboBox.TabIndex = 2;
			// 
			// displayStatelabel
			// 
			this.displayStatelabel.AutoSize = true;
			this.displayStatelabel.Location = new System.Drawing.Point(207, 101);
			this.displayStatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.displayStatelabel.Name = "displayStatelabel";
			this.displayStatelabel.Size = new System.Drawing.Size(115, 17);
			this.displayStatelabel.TabIndex = 3;
			this.displayStatelabel.Text = "displayStatelabel";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.putBackStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(148, 52);
			// 
			// putBackStripMenuItem
			// 
			this.putBackStripMenuItem.Name = "putBackStripMenuItem";
			this.putBackStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.putBackStripMenuItem.Text = "Put It Back";
			this.putBackStripMenuItem.Click += new System.EventHandler(this.putBackStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(211, 132);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(133, 62);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// StatesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 321);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.displayStatelabel);
			this.Controls.Add(this.statesComboBox);
			this.Controls.Add(this.displayLabel);
			this.Controls.Add(this.statesListBox);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

