using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public static class RandomEvents {
		public static void RollForRandomEvent() {
			GameManager.Game.DisplayMessageToUser( "Rolling event..." );

			int rand = GameManager.Rng.Next( 0, 128 );

			switch ( rand ) {
				case 0: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage0 ) ); break;
				case 1: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage1 ) ); break;
				case 2: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage2 ) ); break;
				case 3: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage3 ) ); break;
				case 4: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage4 ) ); break;
				case 5: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage5 ) ); break;
				case 6: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage6 ) ); break;
				case 7: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage7 ) ); break;
				case 8: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage8 ) ); break;
				case 9: GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage9 ) ); break;
				case 10:
					GameManager.Game.DisplayMessageToUser( "You win 100 money in a lottery ticket!" );
					GameManager.Game.Resources[(int)GameManager.ResourceTypes.Money] += 100;
					break;
				case 11:
					GameManager.Game.DisplayMessageToUser( "One of your workers donates some spare materials to you! Lucky!" );
					GameManager.Game.Resources[(int)GameManager.ResourceTypes.Paper] += 25;
					GameManager.Game.Resources[(int)GameManager.ResourceTypes.Plastic] += 25;
					GameManager.Game.Resources[(int)GameManager.ResourceTypes.Scrap] += 25;
					break;
				case 12:
					GameManager.Game.DisplayMessageToUser( "A sudden sickness strikes the company! Half of your free elves can't work today!" );
					GameManager.Game.FreeElves /= 2;
					break;
				case 13:
					GameManager.Game.DisplayMessageToUser( "Your elves work super hard and produce some extra materials!" );
					for ( int i = 0; i < GameManager.Game.AssignedElves.Length; ++i ) {
						GameManager.Game.Resources[i] += GameManager.Game.AssignedElves[i] * 5;
					}
					break;
				case 14:
					if ( GameManager.Game.FreeElves > 3 ) {
						GameManager.Game.DisplayMessageToUser( "One of your workers did not appear to work today." );
						GameManager.Game.FreeElves--;
					}
					break;
				case 15:
					if ( GameManager.Game.FreeElves > 3 ) {
						GameManager.Game.DisplayMessageToUser( "One of your workers quit." );
						GameManager.Game.FreeElves--;
						GameManager.Game.Resources[(int)GameManager.ResourceTypes.Elf]--;
					}
					break;
				case 16:
					GameManager.Game.DisplayMessageToUser( "You failed to pay a bill in time and must pay a fee of 25." );
					GameManager.Game.SubtractMoneyForced( 25 );
					break;
			}
		}

		public static string Decode( string s ) {
			return System.Text.Encoding.UTF8.GetString( System.Convert.FromBase64String( s ) );
		}
	}
}
