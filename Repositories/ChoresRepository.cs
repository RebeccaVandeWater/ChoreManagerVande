using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreManagerVande.Repositories
{
	public class ChoresRepository
	{
		private List<Chore> dbChores;

		public ChoresRepository()
		{
			dbChores = new List<Chore>();
			dbChores.Add(new Chore("Sweep", 15, 2, false));
			dbChores.Add(new Chore("Mop", 20, 1, false));
			dbChores.Add(new Chore("Dishes", 15, 3, true));
			dbChores.Add(new Chore("Clean Cat Box", 7.5, 3, true));
			dbChores.Add(new Chore("Tidy", 5, 4, true));
		}

		internal Chore CreateChore(Chore choreData)
		{
			dbChores.Add(choreData);
			return choreData;
		}

		internal Chore EditChore(Chore choreData, string choreName)
		{
			Chore originalChore = GetChoreByName(choreName);

			originalChore.Name = choreData.Name == null ? originalChore.Name : choreData.Name;
			originalChore.MinutesNeeded = choreData.MinutesNeeded == null ? originalChore.MinutesNeeded : choreData.MinutesNeeded;
			originalChore.TimesPerWeek = choreData.TimesPerWeek == null ? originalChore.TimesPerWeek : choreData.TimesPerWeek;
			originalChore.Completed = choreData.Completed == null ? originalChore.Completed : choreData.Completed;

			dbChores.Remove(originalChore);

			dbChores.Add(choreData);

			return choreData;
		}

		internal Chore GetChoreByName(string choreName)
		{
			Chore foundChore = dbChores.Find(c => c.Name.ToLower() == choreName.ToLower());
			return foundChore;
		}

		internal List<Chore> GetChores()
		{
			return dbChores;
		}

		internal Chore RemoveChore(string choreName)
		{
			Chore choreToRemove = GetChoreByName(choreName);
			dbChores.Remove(choreToRemove);
			return choreToRemove;
		}
	}
}