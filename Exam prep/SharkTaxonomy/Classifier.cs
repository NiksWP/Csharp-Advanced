using System.Runtime.CompilerServices;
using System.Text;

namespace SharkTaxonomy
{
	public class Classifier
	{
		public int Capacity { get; set; }
		public List<Shark> Species { get; set; }
		public int GetCount => Species.Count;
		public Classifier(int capacity)
		{
			this.Capacity = capacity;
			this.Species = new List<Shark>();
		}


		public void AddShark(Shark shark)
		{
			if (this.GetCount < this.Capacity && !this.Species.Any(x => x.Kind == shark.Kind))
			{
				this.Species.Add(shark);
			}
		}

		public bool RemoveShark(string kind)
		{
			Shark shark = Species.FirstOrDefault(x => x.Kind == kind);
			if (shark != null)
			{
				Species.Remove(shark);
				return true;
			}
			return false;
		}

		public string GetLargestShark()
		{
			if (!this.Species.Any())
			{
				return "";
			}
			return Species.OrderByDescending(x => x.Length).FirstOrDefault().ToString().Trim();
		}

		public double GetAverageLength()
		{
			if (!this.Species.Any())
			{
				return 0.00;
			}
			return Species.Average(x => x.Length);
		}

		public string Report()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{this.GetCount} sharks classified:");
			foreach (var shark in Species)
			{
				sb.AppendLine(shark.ToString().TrimEnd());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
