using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template1.ProjectSetup.UsingInMemoryData.Interfaces;

namespace Template1.ProjectSetup.UsingInMemoryData.Controllers
{
	public class SkillsController : Controller
	{
		private readonly ISkillRepository _skillRepository;

		public SkillsController(ISkillRepository skillRepository)
		{
			_skillRepository = skillRepository;
		}
		public IActionResult Index()
		{
			var model = _skillRepository.GetSkills();
			return View(model);
		}
	}
}
