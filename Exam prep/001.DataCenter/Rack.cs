using System.Text;

namespace DataCenter
{
	public class Rack
	{
		public int Slots { get; set; }
		public List<Server> Servers { get; set; }
		public int GetCount => Servers.Count;

		public Rack(int slots)
		{
			this.Slots = slots;
			this.Servers = new List<Server>();
		}

		public void AddServer(Server server)
		{
			if (this.GetCount < this.Slots && !this.Servers.Any(x => x.SerialNumber == server.SerialNumber))
			{
				this.Servers.Add(server);
			}
		}
		public bool RemoveServer (string server)
		{
			Server toRemove = Servers.Where(x => x.SerialNumber == server).FirstOrDefault();

			if (toRemove != null)
			{
				Servers.Remove(toRemove);
				return true;
			}
			return false;
		}
		public string GetHighestPowerUsage()
		{
			Server greatest = Servers.OrderByDescending(x => x.PowerUsage).First();
			return greatest.ToString();
		}

		public int GetTotalCapacity()
		{
			return Servers.Sum(x => x.Capacity);
		}

		public string DeviceManager()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{this.GetCount} servers operating:");
			foreach (var server in Servers)
			{
				sb.AppendLine(server.ToString().TrimEnd());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
