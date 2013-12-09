using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public class GameManager {

		public enum ResourceTypes {
			Elf = 0,
			Money = 1,
			Elec = 2,
			Scrap = 3,
			Plastic = 4,
			Paper = 5,
			Count
		}

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

			Resources[(int)ResourceTypes.Elf] = 20; // already start with some elves
			FreeElves = 20;
			Resources[(int)ResourceTypes.Money] = 500; // and cash
			// and a few other resources
			for ( int i = 2; i < ResourceNames.Length; ++i ) {
				Resources[i] = 50;
			}
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
			if ( Resources[(int)ResourceTypes.Money] > 0 ) {
				Resources[(int)ResourceTypes.Money]--;
				Resources[(int)ResourceTypes.Elf]++;
			} else {
				// inform the player, no money
			}
		}
		public void FireElf() {
			if ( Day % 7 == 0 ) {
				Resources[(int)ResourceTypes.Elf]--;
			} else {
				// inform the player, can only fire on sunday
			}
		}

		public void AdvanceDay() {
			++Day;

			SubtractMoneyForced( Resources[(int)ResourceTypes.Elf] );

			FreeElves = Resources[(int)ResourceTypes.Elf]; // reset elves available for work
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

		public void MakeGift( Gift g ) {
			// check if we have enough resources
			if ( g.RequiredResources[(int)ResourceTypes.Elf] > FreeElves ) {
				return;
			}
			for ( int i = 1; i < g.RequiredResources.Length; ++i ) {
				if ( g.RequiredResources[i] > Resources[i] ) {
					return;
				}
			}

			// if we reach here we have enough, subtract and create gift
			g.OnHandCount++;
			FreeElves -= g.RequiredResources[(int)ResourceTypes.Elf];
			for ( int i = 1; i < g.RequiredResources.Length; ++i ) {
				Resources[i] -= g.RequiredResources[i];
			}
		}

		public void SubtractMoneyForced( int Money ) {
			Resources[(int)ResourceTypes.Money] -= Money;
			if ( Resources[(int)ResourceTypes.Money] < 0 ) {
				DisplayMessageToUser( "Unfortunately, you ran out of money!\n-- GAME OVER --" );
				Environment.Exit( 0 ); // kinda brutal but oh well, need to be fast here
			}
		}

		public void GiftPresentAndGetReward( Gift g, Person p ) {
			--g.OnHandCount;

			// calculate score
			int Score = 0;
			for ( int i = 0; i < p.Stats.Length; ++i ) {
				Score += Math.Abs( g.Stats[i] - p.Stats[i] );
			}

			int Earn = 0;
			if ( Score == 0 ) {
				Earn = 250;
				DisplayMessageToUser( "Perfect gift!\nYou earn 250 Money." );
			} else if ( Score < 5 ) {
				Earn = 200 + ( 5 - Score ) * 10;
				DisplayMessageToUser( "Great gift!\nYou earn " + Earn + " Money." );
			} else if ( Score < 10 ) {
				Earn = 100 + ( 10 - Score ) * 10;
				DisplayMessageToUser( "Good gift!\nYou earn " + Earn + " Money." );
			} else if ( Score < 20 ) {
				Earn = 20 + ( 20 - Score ) * 8;
				DisplayMessageToUser( "Alright gift.\nYou earn " + Earn + " Money." );
			} else if ( Score < 30 ) {
				Earn = ( 30 - Score ) * 4;
				DisplayMessageToUser( "Okay gift.\nYou earn " + Earn + " Money." );
			} else {
				DisplayMessageToUser( "Bad gift.\nYou earn nothing." );
			}

			Resources[(int)ResourceTypes.Money] += Earn;
		}

		public void DisplayMessageToUser( string s ) {
			System.Windows.Forms.MessageBox.Show( s );	
		}
	}
}
