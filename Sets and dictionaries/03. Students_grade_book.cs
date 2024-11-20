int n = int.Parse(Console.ReadLine());
Dictionary<string, List<double>> studentBook = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
	string[] student = Console.ReadLine().Split().ToArray();
	string name = student[0];
	double grade = double.Parse(student[1]);

	if (!studentBook.ContainsKey(name))
	{
		studentBook.Add(name, new List<double>());
		studentBook[name].Add(grade);
		continue;
	}
	studentBook[name].Add(grade);
}

studentBook = studentBook.OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);
foreach (var student in studentBook)
{
	string grades = " " + String.Join(" ", student.Value.Select(g => g.ToString("F2")));
	double average = student.Value.Average();
	Console.WriteLine($"{student.Key} -> {grades} (avg: {average:f2})");
}
