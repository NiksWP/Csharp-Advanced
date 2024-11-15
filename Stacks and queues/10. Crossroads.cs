int greenLight = int.Parse(Console.ReadLine());
int constGreen = greenLight;
int window = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>(); // -1 5

bool crashed = false;
int carsPassed = 0;
string input;
while ((input = Console.ReadLine()) != "END") // 1 + 1 + 1
{
	if (input != "green") // MERCEDES 10 5   2
	{
		cars.Enqueue(input);
	}
	else
	{
		while (cars.Any()) // Докато има коли в опашката
		{
			string car = cars.Peek(); // Вземаме първата кола от опашката, без да я премахваме

			if (car.Length <= greenLight + window && greenLight > 0)
			{
				carsPassed++;
				greenLight -= car.Length; // Намаляваме времето за зелената светлина
				cars.Dequeue(); // Премахваме колата от опашката
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
