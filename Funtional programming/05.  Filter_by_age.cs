using System.Runtime.Serialization;
List<Person> people = ReadPeople();

string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
Action<Person> printer = CreatePrinter(format);
//PrintFilteredPeople(people, filter, printer);



void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
{
    foreach (var person in people)
    {
        if (filter(person))
        {
            printer(person);
        }
    }
}
Action<Person> CreatePrinter(string format)
{
    switch (format)
    {
        case "Name Age": return p => Console.WriteLine($"{p.Name} {p.Age}");
        case "Name": return p => Console.WriteLine($"{p.Name}");
        case "Age": return p => Console.WriteLine($"{p.Age}");
        default:
            return null;
    }
}
Func<Person, bool> CreateFilter(string condition, int ageThreshold)
{
    switch (condition)
    {
        case "younger": return p => p.Age < ageThreshold;
        case "older": return p => p.Age >= ageThreshold;
        default: return null;
    }
    return null;
}


List<Person> ReadPeople()
{
    List<Person> people = new();
    int count = int.Parse(Console.ReadLine());
    for (int i = 0; i < count; i++)
    {
        string[] personTokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        string name = personTokens[0];
        int age = int.Parse(personTokens[1]);
        Person person = new Person();
        person.Name = name;
        person.Age = age;
        people.Add(person);
    }

    return people;
}



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
