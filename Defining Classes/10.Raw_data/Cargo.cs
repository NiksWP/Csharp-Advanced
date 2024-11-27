using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
	public class Cargo
	{
		private string type;
		private int weight;

		public Cargo(int weight, string type)
		{
			this.Weight = weight;
			this.Type = type;
		}

		public string Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}
		public int Weight
		{
			get
			{
				return this.weight;
			}
			set
			{
				this.weight = value;
			}
		}
	}
}
