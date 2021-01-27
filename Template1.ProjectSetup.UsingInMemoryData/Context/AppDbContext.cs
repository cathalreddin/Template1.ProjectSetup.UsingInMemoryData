using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Models;

namespace Template1.ProjectSetup.UsingInMemoryData.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Player> Players { get; set; }
	}
}
