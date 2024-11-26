using CarManufacturer;
using System;

public static class StartUp
{
	public static void Main()
	{
		List<Car> cars = new List<Car>();
		List<Car> specialCars = new List<Car>();

		List<Tire[]> tires = new();
		string tireInput;
		while ((tireInput = Console.ReadLine()) != "No more tires")
		{
			string[] tokens = tireInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			if (tokens.Length % 2 == 0)
			{
				Tire[] tireSet = new Tire[tokens.Length / 2];
				for (int i = 0; i < tokens.Length; i += 2)
				{
					int year = int.Parse(tokens[i]);
					double pressure = double.Parse(tokens[i + 1]);
					tireSet[i / 2] = new Tire(year, pressure);
				}
				tires.Add(tireSet);

			}
		}

		List<KeyValuePair<int, double>> engines = new List<KeyValuePair<int, double>>();
		string engineINput;
		while ((engineINput = Console.ReadLine()) != "Engines done")
		{
			string[] tokens = engineINput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			if (tokens.Length == 2)
			{
				int horsePower = int.Parse(tokens[0]);
				double cc = double.Parse(tokens[1]);
				engines.Add(new KeyValuePair<int, double>(horsePower, cc));

			}
		}

		string input;
		while ((input = Console.ReadLine()) != "Show special")
		{
			string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			if (tokens.Length == 7 || tokens.Length == 2)
			{
				string make = tokens[0];
				string model = tokens[1];
				int year = int.Parse(tokens[2]);
				int fuelQuantity = int.Parse(tokens[3]);
				int fuelConsumption = int.Parse(tokens[4]);
				int engineIndex = int.Parse(tokens[5]);
				int tireIndex = int.Parse(tokens[6]);

				Car car = new Car(make, model, year, fuelQuantity, fuelConsumption);
				Engine engine = new Engine(engines[engineIndex].Key, engines[engineIndex].Value);
				car.Engine = engine;
				car.Engine.CubicCapacity = engines[engineIndex].Value;
				car.Tires = tires[tireIndex];
				cars.Add(car);

				if (car.Year >= 2017 && car.Engine.HorsePower > 330 && (car.Tires.Sum(x => x.Pressure) > 9 && car.Tires.Sum(x => x.Pressure) < 10))
				{
					specialCars.Add(car);
				}
			}
		}

		foreach (var car in specialCars)
		{
			car.FuelQuantity -= 20 * (car.FuelConsumption / 100);
			Console.WriteLine(car.WhoAmI());
		}
	}
}
