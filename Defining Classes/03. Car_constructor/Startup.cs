namespace CarManufacturer;

public class StartUp
{
	public static void Main()
	{
		Car car1 = new Car();
		Car car2 = new Car("BMW", "E46", 2002);
		Car car3 = new Car("VW", "Golf", 2006, 200, 10);
		;
	}
}
