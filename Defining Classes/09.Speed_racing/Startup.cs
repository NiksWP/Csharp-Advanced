namespace SpeedRacing;

public static class StartUp
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		Dictionary<string, Car> cars = new Dictionary<string, Car>();

		for (int i = 0; i < n; i++)
		{
			string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			string model = tokens[0];
			double fuelAmount = double.Parse(tokens[1]);
			double fuelConsumptionPerKilometer = double.Parse(tokens[2]);
			cars.Add(model, new Car(model, fuelAmount, fuelConsumptionPerKilometer));
		}

		string input;
		while ((input = Console.ReadLine()) != "End")
		{
			string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			string command = tokens[0];

			if (command == "Drive")
			{
				string model = tokens[1];
				int km = int.Parse(tokens[2]);
				cars[model].Drive(km);
			}
		}

		foreach (var car in cars)
		{
			Console.WriteLine($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.TraveledDistance}");
		}
	}
}
