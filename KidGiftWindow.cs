using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameSantaTycoon {
	public partial class KidGiftWindow : Form {

		private Person Kid;

		public KidGiftWindow() {
			InitializeComponent();
			Kid = new Person();

			this.labelName.Text = Kid.Name;
			this.labelAge.Text = Kid.Stats[0].ToString() + " years old";

			// stats
			for ( int i = 1; i < Kid.Stats.Length; ++i ) {
				Label l = new Label();
				l.Location = new System.Drawing.Point( 13, 30 + 20 * i );
				l.Size = new System.Drawing.Size( 135, 20 );
				l.Text = GameManager.Game.StatsNames[i] + ": ";// +Kid.Stats[i];
				this.Controls.Add( l );

				ProgressBar p = new ProgressBar();
				p.Location = new System.Drawing.Point( 150, 30 + 20 * i );
				p.Size = new System.Drawing.Size( 100, 20 );
				p.Minimum = 0;
				p.Maximum = 10;
				p.Value = Kid.Stats[i];
				this.Controls.Add( p );
			}

			this.panel1.Controls.Add( new GiveGiftPanel( this, Kid ) );

			this.ResumeLayout( false );
			this.PerformLayout();
		}

		private void button1_Click( object sender, EventArgs e ) {
			this.Close();
			GameManager.Game.SubtractMoneyForced( 10 );
		}
	}
}
