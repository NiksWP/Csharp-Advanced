namespace RawData
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			List<Car> fragileCars = new List<Car>();
			List<Car> flammableCars = new List<Car>();

			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
				string model = tokens[0];
				int engineSpeed = int.Parse(tokens[1]);
				int enginePower = int.Parse(tokens[2]);
				int cargoWeight = int.Parse(tokens[3]);
				string cargoType = tokens[4];
				double tire1Pressure = double.Parse(tokens[5]);
				int tire1Year = int.Parse(tokens[6]);
				double tire2Pressure = double.Parse(tokens[7]);
				int tire2Year = int.Parse(tokens[8]);
				double tire3Pressure = double.Parse(tokens[9]);
				int tire3Year = int.Parse(tokens[10]);
				double tire4Pressure = double.Parse(tokens[11]);
				int tire4Year = int.Parse(tokens[12]);
				Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Year, tire2Pressure, tire2Year
					, tire3Pressure, tire3Year, tire4Pressure, tire4Year);

				if (car.Cargo.Type == "fragile" && car.Tires.Any(x => x.Pressure < 1))
				{
					fragileCars.Add(car);
				}
				else if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
				{
					flammableCars.Add(car);
				}
			}

			string type = Console.ReadLine();
			if (type == "fragile")
			{
				foreach (var car in fragileCars)
				{
					Console.WriteLine(car.Model);
				}
			}
			else
			{
				foreach (var car in flammableCars)
				{
					Console.WriteLine(car.Model);
				}
			}
		}
	}
}