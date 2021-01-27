using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Context;
using Template1.ProjectSetup.UsingInMemoryData.Interfaces;
using Template1.ProjectSetup.UsingInMemoryData.Models;

namespace Template1.ProjectSetup.UsingInMemoryData.Repositories
{
	public class PlayerRepository : IPlayerRepository
	{
		private readonly AppDbContext _appDbContext;

		public PlayerRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public void AddPlayer(Player player)
		{
			_appDbContext.Add(player);
			Commit();
		}

		public void Commit()
		{
			_appDbContext.SaveChanges();
		}

		public void DeletePlayer(Player player)
		{
			_appDbContext.Remove(player);
			Commit();
		}

		public IEnumerable<Player> GetPlayers()
		{
			return _appDbContext.Players;
		}
	}
}
