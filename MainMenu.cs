using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameSantaTycoon {
	public partial class MainMenu : Form {
		public MainMenu() {
			InitializeComponent();
		}

		private void buttonTestKidGift_Click( object sender, EventArgs e ) {
			new KidGiftWindow().Show();
		}
	}
}
