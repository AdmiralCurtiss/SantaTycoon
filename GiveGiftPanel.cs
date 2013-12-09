using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameSantaTycoon {
	public partial class GiveGiftPanel : UserControl {
		public GiveGiftPanel(Form parent, Person p) {
			InitializeComponent();

			int j = 0;
			for ( int i = 0; i < GameManager.Game.Gifts.Count; ++i ) {
				Gift g = GameManager.Game.Gifts[i];

				if ( g.OnHandCount > 0 ) {
					// gift on hand count
					Label l = new Label();
					l.TextAlign = ContentAlignment.MiddleCenter;
					l.Location = new System.Drawing.Point( 0, 0 + j * 30 );
					l.Size = new System.Drawing.Size( 50, 30 );
					l.Text = g.OnHandCount.ToString( "N0" );
					this.Controls.Add( l );

					// make gift buttons
					Button b = new Button();
					b.Location = new System.Drawing.Point( 50, 0 + j * 30 );
					b.Size = new System.Drawing.Size( 150, 30 );
					b.Text = g.Name;
					b.Click += new System.EventHandler(
						delegate( object o, EventArgs arg ) {
							GameManager.Game.GiftPresentAndGetReward( g, p );
							parent.Close();
						}
					);
					this.Controls.Add( b );
					++j;
				}
			}
		}
	}
}
