﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameSantaTycoon {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			GameManager.Game = new GameManager();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainMenu() );
		}
	}
}
