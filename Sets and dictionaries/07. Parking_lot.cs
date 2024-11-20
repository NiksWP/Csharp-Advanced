HashSet<string> plates = new HashSet<string>();
string input;
while ((input = Console.ReadLine()) != "END")
{
	string[] tokens = input.Split(", ").ToArray();
	string command = tokens[0];
	string plate = tokens[1];

	if (command == "IN")
	{
		plates.Add(plate);
	}
	else if (command == "OUT")
	{
		plates.Remove(plate);
	}
}

if (!plates.Any())
{
	Console.WriteLine("Parking Lot is Empty");
}
else
{
	foreach (var cars in plates)
	{
		Console.WriteLine(cars);
	}
}
//IN, CA2844AA
//IN, CA1234TA
//OUT, CA2844AA
//IN, CA9999TT
//IN, CA2866HI
//OUT, CA1234TA
//IN, CA2844AA
//OUT, CA2866HI
//IN, CA9876HH
//IN, CA2822UU
//END