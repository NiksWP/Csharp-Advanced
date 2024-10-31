string[] input = Console.ReadLine().Split();
input = input.Reverse().ToArray();
Stack<string> numsAndOperators = new Stack<string>(input);

while (numsAndOperators.Count > 2)
{
	int firstDigit = int.Parse(numsAndOperators.Pop());
	string @operator = numsAndOperators.Pop();
	int secondDigit = int.Parse(numsAndOperators.Pop());
	int newDigit = 0;

	if (@operator == "-")
	{
		newDigit = firstDigit - secondDigit;
	}
	else
	{
		newDigit = firstDigit + secondDigit;
	}

	numsAndOperators.Push(newDigit.ToString());
}

Console.WriteLine(numsAndOperators.Pop());
