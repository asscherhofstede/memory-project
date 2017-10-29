using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MemoryServer {
	class MemoryServer {
		private static UdpClient socket;
		public static Dictionary<string, MemoryClient> clients = new Dictionary<string, MemoryClient>();

		public static void Log(string message) {
			Console.WriteLine(message);
		}

		static void Main(string[] args) {
			socket = new UdpClient(3000);
			socket.BeginReceive(OnPacketReceived, null);

			Log("Starting MemoryServer");
			UpdateStatistics();
			Console.ReadLine();
		}

		public static void UpdateStatistics() {
			Console.Title = "MemoryServer v0.0.1 | Online: " + clients.Count;
		}

		private static void OnPacketReceived(IAsyncResult ar) {
			IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
			byte[] receivedBytes = socket.EndReceive(ar, ref clientEP);
			MemoryClient client = new MemoryClient(clientEP);
			PacketHandler.HandlePacket(receivedBytes, client);
			socket.BeginReceive(OnPacketReceived, null);
		}
	}
}
