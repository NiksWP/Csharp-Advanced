using System.Diagnostics.Metrics;

Dictionary<string, int> submissionsByLanguage = new Dictionary<string, int>();
Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
string input;
while ((input = Console.ReadLine()) != "exam finished")
{
	string[] tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
	if (tokens.Length < 2 || tokens.Length > 3 || (tokens.Length == 2 && tokens[1] != "banned") || string.IsNullOrEmpty(tokens[0]))
	{
		continue;
	}
	string name = tokens[0];
	string language = tokens[1];
	if (language == "banned")
	{
		result.Remove(name);
		continue;
	}
	int points = int.Parse(tokens[2]);

	if (!result.ContainsKey(name))
	{
		result[name] = new Dictionary<string, int>();
		result[name].Add(language, points);
		if (!submissionsByLanguage.ContainsKey(language))
		{
			submissionsByLanguage[language] = 0;
		}
		submissionsByLanguage[language]++;
		continue;
	}
	if (!result[name].ContainsKey(language))
	{
		result[name][language] = points;
	}
	if (!submissionsByLanguage.ContainsKey(language))
	{
		submissionsByLanguage[language] = 0;
	}

	if (result[name][language] < points)
	{
		result[name][language] = points;
	}
	submissionsByLanguage[language]++;
	continue;
}

Console.WriteLine("Results:");
foreach (var student in result.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
{
	Console.WriteLine($"{student.Key} | {student.Value.Values.Sum()}");
}
Console.WriteLine("Submissions:");
foreach (var language in submissionsByLanguage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
	Console.WriteLine($"{language.Key} - {language.Value}");
}
