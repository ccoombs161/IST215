namespace Buttons_with_Images
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
            this.btnDuck = new System.Windows.Forms.Button();
            this.btnRedDevil = new System.Windows.Forms.Button();
            this.btnWhiteAlien = new System.Windows.Forms.Button();
            this.btnVT = new System.Windows.Forms.Button();
            this.btnMA = new System.Windows.Forms.Button();
            this.btnNH = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDuck
            // 
            this.btnDuck.Image = global::Buttons_with_Images.Properties.Resources.adium;
            this.btnDuck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuck.Location = new System.Drawing.Point(207, 168);
            this.btnDuck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDuck.Name = "btnDuck";
            this.btnDuck.Size = new System.Drawing.Size(56, 19);
            this.btnDuck.TabIndex = 5;
            this.btnDuck.Text = "Little Duckie";
            this.btnDuck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuck.UseVisualStyleBackColor = true;
            this.btnDuck.Click += new System.EventHandler(this.btnDuck_Click);
            // 
            // btnRedDevil
            // 
            this.btnRedDevil.Image = global::Buttons_with_Images.Properties.Resources.firefox_true;
            this.btnRedDevil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDevil.Location = new System.Drawing.Point(207, 90);
            this.btnRedDevil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRedDevil.Name = "btnRedDevil";
            this.btnRedDevil.Size = new System.Drawing.Size(56, 19);
            this.btnRedDevil.TabIndex = 4;
            this.btnRedDevil.Text = "Red Devil";
            this.btnRedDevil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDevil.UseVisualStyleBackColor = true;
            this.btnRedDevil.Click += new System.EventHandler(this.btnRedDevil_Click);
            // 
            // btnWhiteAlien
            // 
            this.btnWhiteAlien.Image = global::Buttons_with_Images.Properties.Resources.alien;
            this.btnWhiteAlien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWhiteAlien.Location = new System.Drawing.Point(207, 12);
            this.btnWhiteAlien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWhiteAlien.Name = "btnWhiteAlien";
            this.btnWhiteAlien.Size = new System.Drawing.Size(56, 19);
            this.btnWhiteAlien.TabIndex = 3;
            this.btnWhiteAlien.Text = "White Alien";
            this.btnWhiteAlien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWhiteAlien.UseVisualStyleBackColor = true;
            this.btnWhiteAlien.Click += new System.EventHandler(this.btnWhiteAlien_Click);
            // 
            // btnVT
            // 
            this.btnVT.BackgroundImage = global::Buttons_with_Images.Properties.Resources.vermont1_thumb;
            this.btnVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVT.Location = new System.Drawing.Point(56, 168);
            this.btnVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVT.Name = "btnVT";
            this.btnVT.Size = new System.Drawing.Size(56, 19);
            this.btnVT.TabIndex = 2;
            this.btnVT.Text = "Vermont";
            this.btnVT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVT.UseVisualStyleBackColor = true;
            this.btnVT.Click += new System.EventHandler(this.btnVT_Click);
            // 
            // btnMA
            // 
            this.btnMA.BackgroundImage = global::Buttons_with_Images.Properties.Resources.massachusetts1_thumb;
            this.btnMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMA.Location = new System.Drawing.Point(56, 90);
            this.btnMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMA.Name = "btnMA";
            this.btnMA.Size = new System.Drawing.Size(56, 19);
            this.btnMA.TabIndex = 1;
            this.btnMA.Text = "Massachusetts";
            this.btnMA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMA.UseVisualStyleBackColor = true;
            this.btnMA.Click += new System.EventHandler(this.btnMA_Click);
            // 
            // btnNH
            // 
            this.btnNH.BackgroundImage = global::Buttons_with_Images.Properties.Resources.new_hampshire1_thumb;
            this.btnNH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNH.Location = new System.Drawing.Point(56, 12);
            this.btnNH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNH.Name = "btnNH";
            this.btnNH.Size = new System.Drawing.Size(56, 19);
            this.btnNH.TabIndex = 0;
            this.btnNH.Text = "New Hampshire";
            this.btnNH.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNH.UseVisualStyleBackColor = true;
            this.btnNH.Click += new System.EventHandler(this.btnNH_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(100, 211);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 233);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDuck);
            this.Controls.Add(this.btnRedDevil);
            this.Controls.Add(this.btnWhiteAlien);
            this.Controls.Add(this.btnVT);
            this.Controls.Add(this.btnMA);
            this.Controls.Add(this.btnNH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Buttons with Images and Icons";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNH;
		private System.Windows.Forms.Button btnMA;
		private System.Windows.Forms.Button btnVT;
		private System.Windows.Forms.Button btnWhiteAlien;
		private System.Windows.Forms.Button btnRedDevil;
		private System.Windows.Forms.Button btnDuck;
		private System.Windows.Forms.Label lblOutput;
	}
}

