using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Interfaces;
using Template1.ProjectSetup.UsingInMemoryData.Models;

namespace Template1.ProjectSetup.UsingInMemoryData.Repositories
{
	public class SkillMemoryRepository : ISkillRepository
	{
		List<Skill> skills = new List<Skill>()
		{
			new Skill { Id=1, Name="ready position", Description="hold hurl in ready position" },
			new Skill { Id=2, Name="ground strike", Description="strike from the ground" },
			new Skill { Id=3, Name="air strike", Description="strike from the hand" }
		};
		public IEnumerable<Skill> GetSkills()
		{
			return skills.ToList();
		}
	}
}
