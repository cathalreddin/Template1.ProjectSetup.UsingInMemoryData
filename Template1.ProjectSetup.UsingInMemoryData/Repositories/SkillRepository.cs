using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Interfaces;
using Template1.ProjectSetup.UsingInMemoryData.Models;

namespace Template1.ProjectSetup.UsingInMemoryData.Repositories
{
	public class SkillRepository : ISkillRepository
	{
		public IEnumerable<Skill> GetSkills()
		{
			throw new NotImplementedException();
		}
	}
}
