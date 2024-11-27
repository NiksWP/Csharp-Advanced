namespace DefiningClasses;

public class StartUp
{
	public static void Main()
	{
		Person person = new Person();
		Person person1 = new Person();
		Person person2 = new Person();
		person.Age = 10;
		person.Name = "koko";
		person2.Age = 20;
		person2.Name = "niki";
		Console.WriteLine(person.Name + " " + person.Age);
		Console.WriteLine(person1.Name + " " + person1.Age);
		Console.WriteLine(person2.Name + " " + person2.Age);
	}
}
