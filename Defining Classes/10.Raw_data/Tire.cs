using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
	public class Tire
	{
		private int age;
		private double pressure;

		public Tire(double pressure, int year)
		{
			this.Pressure = pressure;
			this.Age = year;
		}

		public int Age
		{
			get
			{
				return this.age;
			}
			set
			{
				this.age = value;
			}
		}
		public double Pressure
		{
			get
			{
				return this.pressure;
			}
			set
			{
				this.pressure = value;
			}
		}
	}
}
