using RPGA.Common;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Interfaces
{
	public interface IRoll
	{
		List<int> Dice { get; }

		List<Constants.Abilities> AbilityModifiers();
	}
}