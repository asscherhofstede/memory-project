using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MemoryServer {
	class PacketHandler {
		public static void HandlePacket(byte[] receivedBytes, MemoryClient client) {
			string data = Encoding.ASCII.GetString(receivedBytes);
			string command = data.Substring(0, 3);

			switch (command) {
				case "000":
					OnConnect(data, client);
					break;
				case "001":
					OnDisconnect(data, client);
					break;
			}
		}

		private static void OnConnect(string data, MemoryClient client) {
			Console.WriteLine(client.ID + " connected.");
			if(!MemoryServer.clients.ContainsKey(client.ID)) {
				MemoryServer.clients.Add(client.ID, client);
				MemoryServer.UpdateStatistics();
			}
		}

		private static void OnDisconnect(string data, MemoryClient client) {
			Console.WriteLine(client.ID + " disconnected.");
			if(MemoryServer.clients.ContainsKey(client.ID)) {
				MemoryServer.clients.Remove(client.ID);
				MemoryServer.UpdateStatistics();
			}
		}
	}
}
