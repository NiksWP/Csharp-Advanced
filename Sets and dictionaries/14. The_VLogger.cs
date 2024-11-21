Dictionary<string, (HashSet<string> Followers, int FollowingCount)> vLogger
	= new Dictionary<string, (HashSet<string> Followers, int FollowingCount)>();

string input;
while ((input = Console.ReadLine()) != "Statistics")
{
	string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	if (tokens.Length == 0 || tokens.Length > 4)
	{
		continue;
	}
	string vloggerName = tokens[0];
	string secondVlogger = tokens[2];
	string command = tokens[1];

	if (command == "joined")
	{
		if (!vLogger.ContainsKey(vloggerName))
		{
			vLogger[vloggerName] = (new HashSet<string>(), 0);
		}
	}
	else if (command == "followed" && vLogger.ContainsKey(vloggerName) && vLogger.ContainsKey(secondVlogger)
		&& !vLogger[secondVlogger].Followers.Contains(vloggerName) && vloggerName != secondVlogger)
	{
		vLogger[secondVlogger].Followers.Add(vloggerName);
		vLogger[vloggerName] = (vLogger[vloggerName].Followers, vLogger[vloggerName].FollowingCount + 1);
	}
}

KeyValuePair<string, (HashSet<string> Followers, int FollowingCount)> mostFamous = vLogger.OrderByDescending(x => x.Value.Followers.Count).FirstOrDefault();
Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");
vLogger = vLogger.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.FollowingCount).ToDictionary(x => x.Key, x => x.Value);
int number = 1;
foreach (var logger in vLogger)
{
	Console.WriteLine($"{number}. {logger.Key} : {logger.Value.Followers.Count} followers, {logger.Value.FollowingCount} following");

	if (number == 1)
	{
		foreach (string follower in logger.Value.Followers.OrderBy(f => f))
		{
			Console.WriteLine($"*  {follower}");
		}
	}

	number++;
}
