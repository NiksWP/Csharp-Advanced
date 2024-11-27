namespace DefiningClasses;

public class StartUp
{
	public static void Main()
	{
		Family family = new Family();
		int n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			string name = input[0];
			int age = int.Parse(input[1]);
			family.AddPerson(new Person(name, age));
		}
		Console.WriteLine(family.GetOldestPerson().Name + " " + family.GetOldestPerson().Age);
	}
}
