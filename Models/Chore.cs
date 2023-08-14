using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreManagerVande.Models
{
	public class Chore
	{
		public string Name { get; set; }
		public double? MinutesNeeded { get; set; }
		public int? TimesPerWeek { get; set; }
		public bool? Completed { get; set; }

		public Chore(string name, double? minutesNeeded, int? timesPerWeek, bool? completed)
		{
			Name = name;
			MinutesNeeded = minutesNeeded;
			TimesPerWeek = timesPerWeek;
			Completed = completed;
		}
	}
}