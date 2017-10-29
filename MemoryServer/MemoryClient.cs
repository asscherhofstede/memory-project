using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MemoryServer {
	class MemoryClient {
		public IPEndPoint EndPoint { get; set; }
		public string ID { get; set; }

		public MemoryClient(IPEndPoint endPoint) {
			this.EndPoint = endPoint;
			this.ID = endPoint.Address + ":" + endPoint.Port;
		}
	}
}
