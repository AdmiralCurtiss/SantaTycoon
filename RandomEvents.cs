using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public static class RandomEvents {
		public static void RollForRandomEvent() {
			int rand = GameManager.Rng.Next( 0, 256 );

			//switch ( rand ) {
			//
			//}
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage1 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage2 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage3 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage4 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage5 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage6 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage7 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage8 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage9 ) );
			GameManager.Game.DisplayMessageToUser( Decode( RandomEventSpecialMessages.SpecialMessage0 ) );
		}

		public static string Decode( string s ) {
			return System.Text.Encoding.UTF8.GetString( System.Convert.FromBase64String( s ) );
		}
	}
}
