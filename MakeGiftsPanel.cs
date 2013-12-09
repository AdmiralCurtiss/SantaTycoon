﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameSantaTycoon {
	public partial class MakeGiftsPanel : UserControl {
		public MakeGiftsPanel( MainMenu Menu ) {
			InitializeComponent();

			// there's still some code for Time in here, I don't think I'll actually use it but it's easier to just leave in and ignore

			for ( int i = 0; i < GameManager.Game.Gifts.Count; ++i ) {
				Gift g = GameManager.Game.Gifts[i];

				Button b = new Button();
				b.Location = new System.Drawing.Point( 0, 30 + i * 30 );
				b.Size = new System.Drawing.Size( 150, 30 );
				b.Text = g.Name;
				b.Click += new System.EventHandler(
					delegate( object o, EventArgs arg ) {
						GameManager.Game.MakeGift( g );
						Menu.UpdateDisplay();
					}
				);
				this.Controls.Add( b );

				for ( int j = 0; j < GameManager.Game.ResourceNames.Length /*+ 1*/; ++j ) {
					Label l = new Label();
					l.TextAlign = ContentAlignment.MiddleCenter;
					l.Location = new System.Drawing.Point( 150 + j * 55, 30 + i * 30 );
					l.Size = new System.Drawing.Size( 55, 30 );
					if ( j < GameManager.Game.ResourceNames.Length ) {
						l.Text = g.RequiredResources[j].ToString( "N0" );
					} else {
						l.Text = g.RequiredTime.ToString( "N0" );
					}
					this.Controls.Add( l );
				}
			}

			for ( int j = 0; j < GameManager.Game.ResourceNames.Length /*+ 1*/; ++j ) {
				Label l = new Label();
				l.TextAlign = ContentAlignment.MiddleCenter;
				l.Location = new System.Drawing.Point( 150 + j * 55, 0 );
				l.Size = new System.Drawing.Size( 55, 30 );
				if ( j < GameManager.Game.ResourceNames.Length ) {
					l.Text = GameManager.Game.ResourceNames[j];
				} else {
					l.Text = "Time";
				}
				this.Controls.Add( l );
			}
		}

		
	}
}
