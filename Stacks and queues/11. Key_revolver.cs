int bulletPrice = int.Parse(Console.ReadLine());
int barrelSize = int.Parse(Console.ReadLine());
int[] bulletsSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locksSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int intelligencePrice = int.Parse(Console.ReadLine());

Stack<int> bullets = new Stack<int>(bulletsSizes);
Queue<int> locks = new Queue<int>(locksSizes);

int spentOnBullets = 0;
int bulletsShot = 0;
while (bullets.Count() != 0 && locks.Count() != 0)
{
	if (bulletsShot == barrelSize && bullets.Any())
	{
		Console.WriteLine("Reloading!");
		bulletsShot = 0;
	}

	int currentBullet = bullets.Peek();
	int currentLock = locks.Peek();

	if (currentBullet > currentLock)
	{
		Console.WriteLine("Ping!");
		spentOnBullets += bulletPrice;
		bullets.Pop();
		bulletsShot++;
	}
	else
	{
		Console.WriteLine("Bang!");
		spentOnBullets += bulletPrice;
		bullets.Pop();
		locks.Dequeue();
		bulletsShot++;
	}

	if (bullets.Count == 0 || locks.Count == 0)
	{
		if (bulletsShot == barrelSize && bullets.Count > 0)
		{
			Console.WriteLine("Reloading!");
		}
	}
}

if (!bullets.Any() && locks.Any())
{
	Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else
{
	Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligencePrice - spentOnBullets}");
}
