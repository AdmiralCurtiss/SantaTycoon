namespace GameSantaTycoon {
	partial class MainMenu {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.buttonTestKidGift = new System.Windows.Forms.Button();
			this.labelDay = new System.Windows.Forms.Label();
			this.buttonNextDay = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonTestKidGift
			// 
			this.buttonTestKidGift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTestKidGift.Location = new System.Drawing.Point(12, 353);
			this.buttonTestKidGift.Name = "buttonTestKidGift";
			this.buttonTestKidGift.Size = new System.Drawing.Size(100, 23);
			this.buttonTestKidGift.TabIndex = 0;
			this.buttonTestKidGift.Text = "Give a Present";
			this.buttonTestKidGift.UseVisualStyleBackColor = true;
			this.buttonTestKidGift.Click += new System.EventHandler(this.buttonTestKidGift_Click);
			// 
			// labelDay
			// 
			this.labelDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDay.Location = new System.Drawing.Point(500, 9);
			this.labelDay.Name = "labelDay";
			this.labelDay.Size = new System.Drawing.Size(100, 23);
			this.labelDay.TabIndex = 1;
			this.labelDay.Text = "Day ##";
			this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// buttonNextDay
			// 
			this.buttonNextDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNextDay.Location = new System.Drawing.Point(487, 353);
			this.buttonNextDay.Name = "buttonNextDay";
			this.buttonNextDay.Size = new System.Drawing.Size(113, 23);
			this.buttonNextDay.TabIndex = 2;
			this.buttonNextDay.Text = "Go to Next Day";
			this.buttonNextDay.UseVisualStyleBackColor = true;
			this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(13, 144);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(587, 203);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Gifts:";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 388);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonNextDay);
			this.Controls.Add(this.buttonTestKidGift);
			this.Controls.Add(this.labelDay);
			this.Name = "MainMenu";
			this.Text = "Santa Tycoon";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonTestKidGift;
		private System.Windows.Forms.Label labelDay;
		private System.Windows.Forms.Button buttonNextDay;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}

