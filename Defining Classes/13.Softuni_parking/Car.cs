using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
	public class Car
	{
		private string make;
		private string model;
		private int horsePower;
		private string registrationNumber;

		public Car(string make, string model, int horsePower, string registrationNumber)
		{
			this.Make = make;
			this.Model = model;
			this.HorsePower = horsePower;
			this.RegistrationNumber = registrationNumber;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Make: {this.Make}");
			sb.AppendLine($"Model: {this.Model}");
			sb.AppendLine($"HorsePower: {this.HorsePower}");
			sb.AppendLine($"RegistrationNumber: {this.RegistrationNumber}");
			return sb.ToString().TrimEnd();
		}

		public string Make { get; set; }
		public string Model { get; set; }
		public int HorsePower { get; set; }
		public string RegistrationNumber { get; set; }
	}
}
