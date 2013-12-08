using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public class GameManager {
		public static GameManager Game;

		public string[] ResourceNames = { "Elves", "Electricity", "Scrap", "Money", "Food", "Plastic" };
		public int[] Resources;

		public List<Gift> Gifts;


		public GameManager() {
			Resources = new int[ResourceNames.Length];
			Resources[0] = 20; // already start with some elves

			LoadGifts();
		}

		private void LoadGifts() {
			Gifts = new List<Gift>();

			string[] giftsRaw = System.IO.File.ReadAllLines( "gifts.csv" );
			foreach ( string g in giftsRaw ) {
				if ( g.Trim().StartsWith( "#" ) ) { continue; }
				string[] data = g.Split( ';' );
				if ( data.Length != ResourceNames.Length + 5 ) { continue; }

				Gift gift = new Gift();
				gift.Name = data[0].Trim();
				gift.RequiredResources = new int[ResourceNames.Length];
				for ( int i = 0; i < ResourceNames.Length; ++i ) {
					gift.RequiredResources[i] = Int32.Parse( data[i + 1] );
				}
				gift.RequiredTime = Int32.Parse( data[5] );
				Gifts.Add( gift );
			}

			return;
		}
	}
}
