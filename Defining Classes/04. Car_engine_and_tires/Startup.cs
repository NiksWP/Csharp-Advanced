namespace CarManufacturer;

public class StartUp
{
	public static void Main()
	{
		Tire[] tires = new Tire[4]
		{
			new Tire(1, 2.5),
			new Tire(2, 4.5),
			new Tire(1, 3),
			new Tire(2, 2.0)
		};

		Engine engine = new Engine(560, 6300);
		Car car = new Car("Lamborghini", "Urus", 2020, 50, 18, engine, tires);
	}
}
