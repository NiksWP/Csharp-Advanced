using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
	public class Car
	{
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double traveledDistance;

		public Car(string model, double fuelAmount, double consumption)
		{
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumptionPerKilometer = consumption;
			this.TraveledDistance = 0;
		}

		public void Drive(int km)
		{
			if (this.FuelConsumptionPerKilometer * km <= fuelAmount)
			{
				this.FuelAmount -= this.FuelConsumptionPerKilometer * km;
				this.TraveledDistance += km;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
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
		public double FuelAmount
		{
			get
			{
				return this.fuelAmount;
			}
			set
			{
				this.fuelAmount = value;
			}
		}
		public double FuelConsumptionPerKilometer
		{
			get
			{
				return this.fuelConsumptionPerKilometer;
			}
			set
			{
				this.fuelConsumptionPerKilometer = value;
			}
		}

		public double TraveledDistance
		{
			get
			{
				return this.traveledDistance;
			}
			set
			{
				this.traveledDistance = value;
			}
		}
	}
}
