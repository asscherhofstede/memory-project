using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MemoryServer {
	class Program {
		private static UdpClient socket;

		static void Main(string[] args) {
			socket = new UdpClient(3000);
			socket.BeginReceive(OnPacketReceived, null);
		}

		private static void OnPacketReceived(IAsyncResult ar) {
			IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
			byte[] receivedBytes = socket.EndReceive(ar, ref clientEP);
			string rawData = Encoding.ASCII.GetString(receivedBytes);

			Console.WriteLine(rawData);

			socket.BeginReceive(OnPacketReceived, null);
		}
	}
}
