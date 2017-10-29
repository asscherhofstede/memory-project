using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Memory {
	class Networking {
		private static IPEndPoint serverEP;
		private static UdpClient socket;

		public static void Connect() {
			serverEP = new IPEndPoint(IPAddress.Parse("192.168.0.17"), 3000);
			socket = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
			socket.BeginReceive(OnPacketReceived, null);
			Send("000");
		}

		public static void Disconnect() {
			Send("001");
		}

		public static void Send(string data) {
			byte[] bytes = Encoding.ASCII.GetBytes(data);
			socket.Send(bytes, bytes.Length, serverEP);
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
