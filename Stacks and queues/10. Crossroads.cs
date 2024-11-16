int greenLight = int.Parse(Console.ReadLine());
int constGreen = greenLight;
int window = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();

bool crashed = false;
int carsPassed = 0;
string input;
while ((input = Console.ReadLine()) != "END")
{
	if (input != "green")
	{
		cars.Enqueue(input);
	}
	else
	{
		while (cars.Any())
		{
			string car = cars.Peek();

			if (car.Length <= greenLight + window && greenLight > 0)
			{
				carsPassed++;
				greenLight -= car.Length;
				cars.Dequeue();
				continue;
			}
			if (car.Length > greenLight + window && greenLight > 0)
			{
				Console.WriteLine("A crash happened!");
				Console.WriteLine($"{car} was hit at {car[car.Length - (car.Length - (greenLight + window))]}.");
				crashed = true;
				break;
			}
			else
			{
				break;
			}
		}
	}
	if (crashed)
	{
		break;
	}
	greenLight = constGreen;
}

if (!crashed)
{
	Console.WriteLine("Everyone is safe.");
	Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
}
