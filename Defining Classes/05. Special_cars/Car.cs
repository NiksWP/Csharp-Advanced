using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace CarManufacturer;

public class Car
{
	private string make;
	private string model;
	private int year;
	private double fuelQuantity;
	private double fuelConsumption;
	private Engine engine;
	private Tire[] tires;

	public Car()
	{
		this.Make = "VW";
		this.Model = "Golf";
		this.year = 2025;
		this.fuelQuantity = 200;
		this.fuelConsumption = 10;
	}

	public Car(string make, string model, int year) : this()
	{
		this.Make = make;
		this.model = model;
		this.year = year;
	}

	public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
	{
		this.FuelQuantity = fuelQuantity;
		this.FuelConsumption = fuelConsumption;
	}

	public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
		: this(make, model, year, fuelQuantity, fuelConsumption)
	{
		this.Engine = engine;
		this.Tires = tires;
	}

	public string Make
	{
		get
		{
			return this.make;
		}
		set
		{
			this.make = value;
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
	public int Year
	{
		get
		{
			return this.year;
		}
		set
		{
			this.year = value;
		}
	}
	public double FuelQuantity
	{
		get
		{
			return this.fuelQuantity;
		}
		set
		{
			this.fuelQuantity = value;
		}
	}
	public double FuelConsumption
	{
		get
		{
			return this.fuelConsumption;
		}
		set
		{
			this.fuelConsumption = value;
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

	public void Drive(double distance)
	{
		if (this.fuelQuantity < (this.fuelConsumption / 100) * distance)
		{
			Console.WriteLine($"Not enough fuel to perform this trip!");
		}
		else
		{
			this.fuelQuantity -= (this.fuelConsumption / 100) * distance;
		}
	}

	public string WhoAmI()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine($"Make: {this.Make}");
		sb.AppendLine($"Model: {this.Model}");
		sb.AppendLine($"Year: {this.Year}");
		sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
		sb.AppendLine($"FuelQuantity: {this.fuelQuantity}");

		return sb.ToString().TrimEnd();
	}
}
