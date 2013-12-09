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
			this.SuspendLayout();
			// 
			// buttonTestKidGift
			// 
			this.buttonTestKidGift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTestKidGift.Location = new System.Drawing.Point(12, 353);
			this.buttonTestKidGift.Name = "buttonTestKidGift";
			this.buttonTestKidGift.Size = new System.Drawing.Size(75, 23);
			this.buttonTestKidGift.TabIndex = 0;
			this.buttonTestKidGift.Text = "test kids";
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
			this.buttonNextDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonNextDay.Location = new System.Drawing.Point(93, 353);
			this.buttonNextDay.Name = "buttonNextDay";
			this.buttonNextDay.Size = new System.Drawing.Size(75, 23);
			this.buttonNextDay.TabIndex = 2;
			this.buttonNextDay.Text = "next day";
			this.buttonNextDay.UseVisualStyleBackColor = true;
			this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 388);
			this.Controls.Add(this.buttonNextDay);
			this.Controls.Add(this.buttonTestKidGift);
			this.Controls.Add(this.labelDay);
			this.Name = "MainMenu";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonTestKidGift;
		private System.Windows.Forms.Label labelDay;
		private System.Windows.Forms.Button buttonNextDay;
	}
}

