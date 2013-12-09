using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public class Person {
		public int[] Stats;
		public string Name = "None";

		public Person() {
			Stats = new int[GameManager.Game.StatsNames.Length];
			Stats[0] = GameManager.Rng.Next( 3, 19 );
			for ( int i = 1; i < GameManager.Game.StatsNames.Length; ++i ) {
				Stats[i] = GameManager.Rng.Next( 0, 11 );
			}

			Name = GameManager.Game.Names[GameManager.Rng.Next( 0, GameManager.Game.Names.Length )];
		}
	}
}
