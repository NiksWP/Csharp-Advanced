using System.Linq;

namespace PokemonTrainer;

public class StartUp
{
	public static void Main()
	{
		List<Trainer> trainers = new List<Trainer>();
		string input;
		while ((input = Console.ReadLine()) != "Tournament")
		{
			string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			if (tokens.Length != 4)
			{
				continue;
			}

			string trainerName = tokens[0];
			string pokemonName = tokens[1];
			string pokemonElement = tokens[2];
			int pokemonHealth = int.Parse(tokens[3]);
			Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

			if (!trainers.Any(x => x.Name == trainerName))
			{
				Trainer trainer = new Trainer(trainerName);
				trainer.Pokemons = new List<Pokemon>();
				trainers.Add(trainer);
			}

			trainers.First(x => x.Name == trainerName).Pokemons.Add(pokemon);
		}

		List<Pokemon> toRemove = new List<Pokemon>();
		bool hasToRemove = false;
		string element;
		while ((element = Console.ReadLine()) != "End")
		{
			foreach (var trainer in trainers)
			{
				if (trainer.Pokemons.Any(x => x.Element == element))
				{
					trainer.NumberOfBadges += 1;
				}
				else
				{
					foreach (var pokemon in trainer.Pokemons)
					{
						pokemon.Health -= 10;
						if (pokemon.Health <= 0)
						{
							//trainer.Pokemons.Remove(pokemon);
							toRemove.Add(pokemon);
						}
					}
				}
				foreach (var pokemon in toRemove)
				{
					trainer.Pokemons.Remove(pokemon);
				}
			}
		}

		foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
		{
			Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
		}
	}
}
