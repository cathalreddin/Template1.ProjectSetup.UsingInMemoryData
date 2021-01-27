using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Interfaces;
using Template1.ProjectSetup.UsingInMemoryData.Models;
using Template1.ProjectSetup.UsingInMemoryData.ViewModels;

namespace Template1.ProjectSetup.UsingInMemoryData.Controllers
{
	public class PlayersController : Controller
	{
		private readonly IPlayerRepository _playerRepository;

		public PlayersController(IPlayerRepository playerRepository)
		{
			_playerRepository = playerRepository;
		}
		public IActionResult Index()
		{
			var model = _playerRepository.GetPlayers();					
			return View(model);
		}
		public IActionResult Create() => View();
		
		[HttpPost]
		public IActionResult Create(PlayerViewModel model)
		{
			if (!ModelState.IsValid)
				return View();

			var player = new Player()
			{			
				Name = model.Name
			};

			_playerRepository.AddPlayer(player);

			return RedirectToAction("Index"); 
		}
	}
}
