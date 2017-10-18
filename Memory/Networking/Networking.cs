using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Memory.Networking {
	class Networking {
		private static UdpClient socket;

		public static void Connect() {

			socket = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
			socket.BeginReceive(OnPacketReceived, null);
		}

		private static void OnPacketReceived(IAsyncResult ar) {
			
			socket.BeginReceive(OnPacketReceived, null);
		}
	}
}
