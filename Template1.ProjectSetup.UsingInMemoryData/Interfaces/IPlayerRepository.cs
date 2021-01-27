using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Models;

namespace Template1.ProjectSetup.UsingInMemoryData.Interfaces
{
	public interface IPlayerRepository
	{
		IEnumerable<Player> GetPlayers();
		void AddPlayer(Player player);
		void DeletePlayer(Player player);

	}
}
