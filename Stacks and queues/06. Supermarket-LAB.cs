Queue<string> customers = new Queue<string>();

string input;
while ((input = Console.ReadLine()) != "End")
{
	if (input != "Paid")
	{
		customers.Enqueue(input);
	}
	else if (input == "Paid" && customers.Any())
	{
		int length = customers.Count();
		for (int i = 0; i < length; i++)
		{
			Console.WriteLine(customers.Dequeue());
		}
	}
}

Console.WriteLine($"{customers.Count} people remaining.");
