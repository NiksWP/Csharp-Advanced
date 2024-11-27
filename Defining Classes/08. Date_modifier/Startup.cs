namespace DateModifier;

public class StartUp
{
	public static void Main()
	{
		string date1 = Console.ReadLine();
		string date2 = Console.ReadLine();
		DateModifier dateModifier = new DateModifier();
		Console.WriteLine(dateModifier.CalculateTwoDAtes(date1, date2));
	}
}
