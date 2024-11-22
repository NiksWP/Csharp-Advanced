Dictionary<string, HashSet<string>> sides = new Dictionary<string, HashSet<string>>();
Dictionary<string, string> people = new Dictionary<string, string>();
string input;
while ((input = Console.ReadLine()) != "Lumpawaroo")
{
	bool isNew = false;
	if (input.Contains(" | "))
	{
		string[] tokens = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
		string forceSide = tokens[0];
		string forceUser = tokens[1];

		AddPeople(sides, forceUser, forceSide, ref isNew);
	}
	else if (input.Contains(" -> "))
	{
		string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
		string forceUser = tokens[0];
		string forceSide = tokens[1];

		AddPeople(sides, forceUser, forceSide, ref isNew);

		if (isNew == true)
		{
			Console.WriteLine($"{forceUser} joins the {forceSide} side!");
			continue;
		}

		if (!sides[forceSide].Contains(forceUser))
		{
			sides[forceSide].Add(forceUser);
			sides[people[forceUser]].Remove(forceUser);
			people[forceUser] = forceSide;
			Console.WriteLine($"{forceUser} joins the {forceSide} side!");
		}
	}
}

foreach (var side in sides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
	if (side.Value.Count == 0)
	{
		continue;
	}

	Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
	foreach (var person in side.Value.OrderBy(x => x))
	{
		Console.WriteLine($"! {person}");
	}
}

void AddPeople(Dictionary<string, HashSet<string>> sides, string forceUser, string forceSide, ref bool IsNew)
{
	if (!sides.ContainsKey(forceSide))
	{
		sides.Add(forceSide, new HashSet<string>());
	}
	if (!people.ContainsKey(forceUser))
	{
		people[forceUser] = forceSide;
		sides[forceSide].Add(forceUser);
		IsNew = true;
	}
}
