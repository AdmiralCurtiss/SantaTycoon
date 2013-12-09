using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameSantaTycoon {
	public partial class MainMenu : Form {
		private Label[] labelsResources;
		private Label[] labelsAssignedElves;
		private MakeGiftsPanel GiftPanel;

		public MainMenu() {
			InitializeComponent();

			labelsResources = new Label[GameManager.Game.ResourceNames.Length];
			for ( int i = 0; i < GameManager.Game.ResourceNames.Length; ++i ) {
				Label l = new Label();
				l.Location = new System.Drawing.Point( 20 + i * 55, 9 );
				l.Size = new System.Drawing.Size( 55, 30 );
				l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.Controls.Add( l );
				labelsResources[i] = l;
			}

			labelsAssignedElves = new Label[GameManager.Game.ResourceNames.Length];
			for ( int i = 0; i < GameManager.Game.ResourceNames.Length; ++i ) {
				Label l = new Label();
				l.Location = new System.Drawing.Point( 20 + i * 55, 39 );
				l.Size = new System.Drawing.Size( 55, 30 );
				l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.Controls.Add( l );
				labelsAssignedElves[i] = l;
			}

			for ( int i = 2; i < GameManager.Game.ResourceNames.Length; ++i ) {
				int localI = i;

				// assign button
				Button b = new Button();
				b.Location = new System.Drawing.Point( 20 + i * 55, 69 );
				b.Size = new System.Drawing.Size( 55, 23 );
				b.Text = "+";
				b.Click += new System.EventHandler(
					delegate( object o, EventArgs arg ) {
						GameManager.Game.AssignElf( localI );
						UpdateDisplay();
					}
				);
				this.Controls.Add( b );

				// unassign button
				b = new Button();
				b.Location = new System.Drawing.Point( 20 + i * 55, 69 + 23 );
				b.Size = new System.Drawing.Size( 55, 23 );
				b.Text = "-";
				b.Click += new System.EventHandler(
					delegate( object o, EventArgs arg ) {
						GameManager.Game.UnassignElf( localI );
						UpdateDisplay();
					}
				);
				this.Controls.Add( b );
			}

			// hire button
			Button hireButton = new Button();
			hireButton.Location = new System.Drawing.Point( 20, 69 );
			hireButton.Size = new System.Drawing.Size( 55, 23 );
			hireButton.Text = "Hire";
			hireButton.Click += new System.EventHandler(
				delegate( object o, EventArgs arg ) {
					GameManager.Game.HireElf();
					UpdateDisplay();
				}
			);
			this.Controls.Add( hireButton );

			// fire button
			Button fireButton = new Button();
			fireButton.Location = new System.Drawing.Point( 20, 69 + 23 );
			fireButton.Size = new System.Drawing.Size( 55, 23 );
			fireButton.Text = "Fire";
			fireButton.Click += new System.EventHandler(
				delegate( object o, EventArgs arg ) {
					GameManager.Game.FireElf();
					UpdateDisplay();
				}
			);
			this.Controls.Add( fireButton );

			GiftPanel = new MakeGiftsPanel( this );
			this.panel1.Controls.Add( GiftPanel );

			this.labelDay.SendToBack();

			UpdateDisplay();
		}

		public void UpdateDisplay() {
			labelDay.Text = "Day " + GameManager.Game.Day.ToString();
			for ( int i = 0; i < GameManager.Game.ResourceNames.Length; ++i ) {
				labelsResources[i].Text = GameManager.Game.ResourceNames[i] + "\n" + GameManager.Game.Resources[i].ToString( "N0" );
			}
			labelsAssignedElves[0].Text = "Free\n" + GameManager.Game.FreeElves.ToString( "N0" );
			for ( int i = 2; i < GameManager.Game.ResourceNames.Length; ++i ) {
				labelsAssignedElves[i].Text = "Assigned\n" + GameManager.Game.AssignedElves[i].ToString( "N0" );
			}

			// gift on hand count
			for ( int i = 0; i < GameManager.Game.Gifts.Count; ++i ) {
				Gift g = GameManager.Game.Gifts[i];
				GiftPanel.labelsGifts[i].Text = g.OnHandCount.ToString( "N0" );
			}
		}

		private void buttonTestKidGift_Click( object sender, EventArgs e ) {
			new KidGiftWindow().ShowDialog();
		}

		private void buttonNextDay_Click( object sender, EventArgs e ) {
			GameManager.Game.AdvanceDay();
			UpdateDisplay();
		}
	}
}
