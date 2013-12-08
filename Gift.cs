using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSantaTycoon {
	public class Gift {

		public string Name;
		public int[] RequiredResources;
		public int RequiredTime;

		public string Quote;
		public string PersonalityLike;
		public string PersonalityDislike;

		public override string ToString() {
			return Name;
		}
	}
}
