HashSet<string> vip = new HashSet<string>();
HashSet<string> regular = new HashSet<string>();

bool partyStarted = false;
string input;
while ((input = Console.ReadLine()) != "END")
{
	string id = input;
	if (id == "PARTY")
	{
		partyStarted = true;
		break;
	}

	if (id != "PARTY" && partyStarted == false)
	{
		if (char.IsDigit(id[0]))
		{
			vip.Add(id);
		}
		else
		{
			regular.Add(id);
		}
	}
}

string secondInput;
while ((secondInput = Console.ReadLine()) != "END")
{
	string id = secondInput;
	if (char.IsDigit(id[0]))
	{
		vip.Remove(id);
	}
	else
	{
		regular.Remove(id);
	}
}

int sum = vip.Count + regular.Count;
Console.WriteLine(sum);
foreach (var guest in vip)
{
	Console.WriteLine(guest);
}
foreach (var guest in regular)
{
	Console.WriteLine(guest);
}
