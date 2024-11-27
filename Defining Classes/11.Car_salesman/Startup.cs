using System.Drawing;

namespace CarSalesman;

public class StartUp
{
	public static void Main()
	{
		List<Engine> engines = new List<Engine>();
		List<Car> cars = new List<Car>();
		int n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

			string model = tokens[0];
			int power = int.Parse(tokens[1]);
			Engine engine = new Engine(model, power);
			if (tokens.Length == 3)
			{
				if (int.TryParse(tokens[2], out int result))
				{
					engine.Displacement = result;
				}
				else
				{
					engine.Efficiency = tokens[2];
				}
			}
			if (tokens.Length == 4)
			{
				int displacement = int.Parse(tokens[2]);
				engine.Displacement = displacement;
				string efficiency = tokens[3];
				engine.Efficiency = efficiency;
			}
			engines.Add(engine);
		}

		int m = int.Parse(Console.ReadLine());
		for (int i = 0; i < m; i++)
		{
			string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			string model = tokens[0];
			string engine = tokens[1];
			Engine carEngine = engines.FirstOrDefault(e => e.Model == engine);

			Car car = new Car(model, carEngine);
			if (tokens.Length == 3)
			{
				if (int.TryParse(tokens[2], out int result))
				{
					car.Weight = result;
				}
				else
				{
					car.Color = tokens[2];
				}
			}
			if (tokens.Length == 4)
			{
				int weight = int.Parse(tokens[2]);
				car.Weight = weight;
				string color = tokens[3];
				car.Color = color;
			}

			cars.Add(car);
		}

		foreach (var car in cars)
		{
			car.ToString();
		}
	}
}
