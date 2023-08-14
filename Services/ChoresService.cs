using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreManagerVande.Services
{
	public class ChoresService
	{

		private readonly ChoresRepository _choresRepository;

		public ChoresService(ChoresRepository choresRepository)
		{
			_choresRepository = choresRepository;
		}
		internal List<Chore> GetChores()
		{
			List<Chore> chores = _choresRepository.GetChores();
			return chores;
		}

		internal Chore GetChoreByName(string choreName)
		{
			Chore chore = _choresRepository.GetChoreByName(choreName);

			if (chore == null)
			{
				throw new Exception($"There is no chore with the name {choreName}");
			}

			return chore;
		}

		internal Chore CreateChore(Chore choreData)
		{
			Chore chore = _choresRepository.CreateChore(choreData);
			return chore;
		}

		internal Chore RemoveChore(string choreName)
		{
			Chore chore = _choresRepository.RemoveChore(choreName);
			return chore;
		}

		internal Chore EditChore(Chore choreData, string choreName)
		{
			Chore chore = _choresRepository.EditChore(choreData, choreName);
			return chore;
		}
	}
}