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
			this.SuspendLayout();
			// 
			// buttonTestKidGift
			// 
			this.buttonTestKidGift.Location = new System.Drawing.Point(13, 227);
			this.buttonTestKidGift.Name = "buttonTestKidGift";
			this.buttonTestKidGift.Size = new System.Drawing.Size(75, 23);
			this.buttonTestKidGift.TabIndex = 0;
			this.buttonTestKidGift.Text = "test kids";
			this.buttonTestKidGift.UseVisualStyleBackColor = true;
			this.buttonTestKidGift.Click += new System.EventHandler(this.buttonTestKidGift_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonTestKidGift);
			this.Name = "MainMenu";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonTestKidGift;
	}
}

