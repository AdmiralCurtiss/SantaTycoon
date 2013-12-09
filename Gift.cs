using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public class Gift {

		public string Name;
		public int[] RequiredResources;
		public int[] Stats;
		public int RequiredTime;

		public int OnHandCount;

		public string Quote;
		public string PersonalityLike;
		public string PersonalityDislike;

		public override string ToString() {
			return Name;
		}
	}
}
