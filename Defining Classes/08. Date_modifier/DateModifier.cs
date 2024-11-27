using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
	public class DateModifier
	{
		public int CalculateTwoDAtes(string first, string second)
		{
			DateTime date1 = DateTime.Parse(first);
			DateTime date2 = DateTime.Parse(second);

			TimeSpan difference = date2 - date1;

			return Math.Abs(difference.Days);
		}
	}
}
