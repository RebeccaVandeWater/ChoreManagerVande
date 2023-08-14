using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChoreManagerVande.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ChoresController : ControllerBase
	{

		private readonly ChoresService _choresService;

		public ChoresController(ChoresService choresService)
		{
			_choresService = choresService;
		}

		[HttpGet]
		public ActionResult<List<Chore>> GetChores()
		{
			try
			{
				List<Chore> chores = _choresService.GetChores();
				return Ok(chores);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpGet("{choreName}")]

		public ActionResult<Chore> GetChoreByName(string choreName)
		{
			try
			{
				Chore chore = _choresService.GetChoreByName(choreName);
				return Ok(chore);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
		{
			try
			{
				Chore chore = _choresService.CreateChore(choreData);
				return Ok(chore);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpDelete("{choreName}")]

		public ActionResult<Chore> RemoveChore(string choreName)
		{
			try
			{
				Chore chore = _choresService.RemoveChore(choreName);
				return Ok($"The chore with the name {choreName} has been removed!");
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPut("{choreName}")]

		public ActionResult<Chore> EditChore([FromBody] Chore choreData, string choreName)
		{
			try
			{
				Chore chore = _choresService.EditChore(choreData, choreName);
				return Ok(chore);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

	}
}