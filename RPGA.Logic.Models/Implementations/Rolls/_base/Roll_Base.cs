using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Rolls
{
	public class Roll_Base : IRoll
	{
		private List<int> _dice { get; }
		private List<Constants.Abilities> _abilityModifiers { get; }

		public Roll_Base(List<int> dice, List<Constants.Abilities> abilityModifiers = null)
		{
			_dice = dice;
			_abilityModifiers = abilityModifiers;
		}

		public List<int> Dice => _dice;
		public List<Constants.Abilities> AbilityModifiers() => _abilityModifiers;
	}
}