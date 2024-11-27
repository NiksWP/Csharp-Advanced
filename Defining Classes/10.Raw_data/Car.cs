using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
	public class Car
	{
		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire[] tires;

		public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Year,
			double tire2Pressure, int tire2Year, double tire3Pressure, int tire3Year, double tire4Pressure, int tire4Year)
		{
			this.Model = model;
			this.Engine = new Engine(engineSpeed, enginePower);
			this.Cargo = new Cargo(cargoWeight, cargoType);
			this.Tires = new Tire[4];
			this.Tires[0] = new Tire(tire1Pressure, tire1Year);
			this.Tires[1] = new Tire(tire2Pressure, tire2Year);
			this.Tires[2] = new Tire(tire3Pressure, tire3Year);
			this.Tires[3] = new Tire(tire4Pressure, tire4Year);
		}

		public string Model
		{
			get
			{
				return this.model;
			}
			set
			{
				this.model = value;
			}
		}
		public Engine Engine
		{
			get
			{
				return this.engine;
			}
			set
			{
				this.engine = value;
			}
		}
		public Cargo Cargo
		{
			get
			{
				return this.cargo;
			}
			set
			{
				this.cargo = value;
			}
		}
		public Tire[] Tires
		{
			get
			{
				return this.tires;
			}
			set
			{
				this.tires = value;
			}
		}
	}
}
