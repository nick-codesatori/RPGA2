using RPGA.Common;
using System.Collections.Generic;

namespace RPGA.Presentation.Models
{
	public class RollVM
	{
		public List<int> Dice { get; set; }

		public List<Constants.Abilities> AbilityModifiers { get; set; }
	}
}