using System;

Dictionary<string, string> contests = new Dictionary<string, string>();
string input;
while ((input = Console.ReadLine()) != "end of contests")
{
	string contestName = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray()[0];
	string contestPassword = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray()[1];

	if (!contests.ContainsKey(contestName))
	{
		contests[contestName] = "";
	}
	contests[contestName] = contestPassword;
}

Dictionary<string, Dictionary<string, int>> studentBook = new Dictionary<string, Dictionary<string, int>>();
string students;
while ((students = Console.ReadLine()) != "end of submissions")
{
	string[] tokens = students.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
	string contestName = tokens[0];
	string contestPass = tokens[1];
	string student = tokens[2];
	int points = int.Parse(tokens[3]);

	if (contests.ContainsKey(contestName) && contests[contestName] == contestPass)
	{
		if (!studentBook.ContainsKey(student))
		{
			studentBook[student] = new Dictionary<string, int>();
			studentBook[student][contestName] = points;
			continue;
		}
		if (studentBook[student].ContainsKey(contestName) && studentBook[student][contestName] < points)
		{
			studentBook[student][contestName] = points;
			continue;
		}
		if (studentBook[student].ContainsKey(contestName) && studentBook[student][contestName] >= points)
		{
			continue;
		}

		studentBook[student].Add(contestName, points);
	}
}
var bestStudent = studentBook.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault();
Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.Values.Sum()} points.");
Console.WriteLine("Ranking:");
foreach (var student in studentBook.OrderBy(x => x.Key))
{
	Console.WriteLine(student.Key);
	foreach (var contest in student.Value.OrderByDescending(x => x.Value))
	{
		Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
	}
}
