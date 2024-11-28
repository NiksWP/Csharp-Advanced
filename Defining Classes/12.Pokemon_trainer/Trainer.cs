using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
	public class Trainer
	{
		private string name;
		private int numberOfBadges;
		private List<Pokemon> pokemons;

		public Trainer(string name)
		{
			this.Name = name;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		public int NumberOfBadges
		{
			get
			{
				return this.numberOfBadges;
			}
			set
			{
				this.numberOfBadges = value;
			}
		}
		public List<Pokemon> Pokemons
		{
			get
			{
				return this.pokemons;
			}
			set
			{
				this.pokemons = value;
			}
		}
	}
}
