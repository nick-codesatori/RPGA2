using RPGA.Common;
using RPGA.Logic.Models.Implementations.Rolls;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Attacks
{
	public class Attack_Claw : Attack_Base
	{
		#region overrides
		public override string Description() => "Claw Attack";
		public override Constants.DamageTypes DamageType() => Constants.DamageTypes.Piercing;

		public override IRoll Damage()
		{
			return new Roll_Base(
				new List<int> { 6 },
				new List<Constants.Abilities> { Constants.Abilities.Strength }
			);
		}

		public override IRoll Attack()
		{
			return new Roll_Base(
				new List<int> { 20 },
				new List<Constants.Abilities> { Constants.Abilities.Strength }
			);
		}
		#endregion
	}
}