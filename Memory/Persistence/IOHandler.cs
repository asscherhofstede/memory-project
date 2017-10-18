using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory {
	class IOHandler {
		public static List<Save> GetSaves() {
			List<Save> paths = new List<Save>();
			string savesPath = Path.Combine(Environment.CurrentDirectory, "saves");
			foreach (string file in Directory.EnumerateFiles(savesPath, "*.sav")) {
				string fileName = Path.GetFileName(file);
				Save save = SaveHandler.Read(fileName);
				paths.Add(save);
			}
			return paths;
		}
	}
}