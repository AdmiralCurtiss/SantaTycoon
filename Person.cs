using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	class Person {
		public int[] Stats;
		public static Random Rng = new Random();

		public string Name = "None";

		public Person() {
			Stats = new int[GameManager.Game.StatsNames.Length];
			Stats[0] = Rng.Next( 3, 19 );
			for ( int i = 1; i < GameManager.Game.StatsNames.Length; ++i ) {
				Stats[i] = Rng.Next( 0, 11 );
			}
		}
	}
}
