﻿namespace GameSantaTycoon {
	partial class KidGiftWindow {
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
			this.labelName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.labelAge = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(13, 13);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(33, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "name";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(386, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(13, 30);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(25, 13);
			this.labelAge.TabIndex = 2;
			this.labelAge.Text = "age";
			// 
			// KidGiftWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 262);
			this.Controls.Add(this.labelAge);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelName);
			this.Name = "KidGiftWindow";
			this.Text = "KidGiftWindow";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelAge;
	}
}