using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace Memory {

	public struct Save {
		public string Username { get; set; }
		public int Score { get; set; }
	}

	class SaveHandler {
		public static void Save(string fileName) {
			string path = Path.Combine(Environment.CurrentDirectory, "saves", fileName);

			Save save = new Save();
			save.Username = "Kevin";
			save.Score = 10;

			Console.WriteLine(save.Username);

			string data = JsonMapper.ToJson(save);
			File.WriteAllText(path, data);
		}

		public static Save Read(string fileName) {
			string path = Path.Combine(Environment.CurrentDirectory, "saves", fileName);
			JsonData rawData = JsonMapper.ToObject(File.ReadAllText(path));

			Save save = new Save();
			save.Username = rawData[0].ToString();
			save.Score = int.Parse(rawData[1].ToString());

			return save;
		}

		public static void Delete(string fileName) {
			string path = Path.Combine(Environment.CurrentDirectory, "saves", fileName);
			File.Delete(path);
		}
	}
}