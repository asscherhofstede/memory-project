using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory {
	static class Program {
		[STAThread]
		static void Main() {
			List<Save> saves = IOHandler.GetSaves();
			foreach(Save save in saves) {
				Console.WriteLine(save.Username);
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

		}
	}
}
