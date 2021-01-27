using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template1.ProjectSetup.UsingInMemoryData.ViewModels
{
	public class PlayerViewModel
	{
		[Display(Name="Player Name")]
		public string Name { get; set; }
	}
}
