using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public class GameManager {
		public static GameManager Game;

		public string[] ResourceNames = { "Elves", "Money", "Electricity", "Scrap", "Plastic", "Paper" };
		public string[] StatsNames = { "Age", "Playfulness", "Social Interaction", "Learning Aptitude", "Creativity" };
		public List<Gift> Gifts;

		public int[] Resources;
		public int Day;
		public int FreeElves;
		public int[] AssignedElves;

		public GameManager() {
			Resources = new int[ResourceNames.Length];
			AssignedElves = new int[ResourceNames.Length];

			Resources[0] = 20; // already start with some elves
			FreeElves = 20;
			Resources[1] = 1000; // and cash
			Day = 1;

			LoadGifts();
		}

		private void LoadGifts() {
			Gifts = new List<Gift>();

			string[] giftsRaw = System.IO.File.ReadAllLines( "gifts.csv" );
			foreach ( string g in giftsRaw ) {
				if ( g.Trim().StartsWith( "#" ) ) { continue; }
				string[] data = g.Split( ';' );
				if ( data.Length != ResourceNames.Length + 2 + StatsNames.Length ) { continue; }

				Gift gift = new Gift();
				gift.Name = data[0].Trim();
				gift.RequiredResources = new int[ResourceNames.Length];
				for ( int i = 0; i < ResourceNames.Length; ++i ) {
					gift.RequiredResources[i] = Int32.Parse( data[i + 1] );
				}

				gift.RequiredTime = Int32.Parse( data[ResourceNames.Length + 1] );

				gift.Stats = new int[StatsNames.Length];
				for ( int i = 0; i < StatsNames.Length; ++i ) {
					gift.Stats[i] = Int32.Parse( data[i + ResourceNames.Length + 2] );
				}
				Gifts.Add( gift );
			}

			return;
		}

		public void HireElf() {
			Resources[0]++;
		}

		public void AdvanceDay() {
			++Day;

			Resources[1] -= Resources[0]; // pay elves
			if ( Resources[1] < 0 ) {
				// OUT OF MONEY, GAME OVER
			}

			FreeElves = Resources[0]; // reset elves available for work
			// and subtract all elves assigned to material production
			for ( int i = 0; i < AssignedElves.Length; ++i ) {
				FreeElves -= AssignedElves[i];
			}

			// then add resources from assigned elves
			for ( int i = 0; i < AssignedElves.Length; ++i ) {
				Resources[i] += AssignedElves[i] * 10;
			}
		}

		public void AssignElf( int ResourceToAssignTo ) {
			if ( FreeElves > 0 ) {
				FreeElves--;
				AssignedElves[ResourceToAssignTo]++;
			}
		}
		public void UnassignElf( int ResourceToAssignTo ) {
			if ( AssignedElves[ResourceToAssignTo] > 0 ) {
				AssignedElves[ResourceToAssignTo]--;
			}
		}
	}
}
