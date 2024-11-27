namespace DefiningClasses;

internal class Person
{
	private string name;
	private int age;

	public Person()
	{
		this.Name = "someName";
		this.Age = 0;
	}

	public string Name { get; set; }
	public int Age { get; set; }
}
