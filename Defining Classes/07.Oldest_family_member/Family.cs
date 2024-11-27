using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
	public class Family
	{
		private List<Person> familyMembers = new List<Person>();


		public void AddPerson(Person person)
		{
			this.familyMembers.Add(person);
		}

		public Person GetOldestPerson()
		{
			return familyMembers.OrderByDescending(x => x.Age).ToList().First();
		}
	}
}
