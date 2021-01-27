using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Interfaces;
using Template1.ProjectSetup.UsingInMemoryData.Models;

namespace Template1.ProjectSetup.UsingInMemoryData.Repositories
{
	public class PlayerMemoryRepository : IPlayerRepository
	{		
		List<Player> players = new List<Player>()
		{ 
			new Player { Id=1, Name="John" },
			new Player { Id=2, Name="Mary" },
			new Player { Id=3, Name="Pat" },
		};

		public void AddPlayer(Player player)
		{
			players.Add(player);
		}

		public void DeletePlayer(Player player)
		{
			players.Remove(player);
		}

		public IEnumerable<Player> GetPlayers()
		{
			return players.ToList();
		}
	}
}
