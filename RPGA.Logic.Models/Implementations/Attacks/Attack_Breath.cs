using RPGA.Common;
using RPGA.Logic.Models.Implementations.Rolls;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Attacks
{
	public class Attack_Breath : Attack_Base
	{
		#region internal
		private Constants.DamageTypes _damageType { get; }
		private Constants.AttackShapes _shape { get; }
		private int _range { get; }
		private Constants.Abilities _save { get; }

		public Attack_Breath(Constants.DamageTypes _newType, Constants.AttackShapes _newShape, Constants.Abilities _newSave, int _newRange)
		{
			_damageType = _newType;
			_shape = _newShape;
			_save = _newSave;
			_range = _newRange;
		}
		#endregion
		#region overrides
		public override string Description() => "Breath Attack";
		public override Constants.DamageTypes DamageType() => _damageType;
		public override Constants.AttackShapes? Shape() => _shape;
		public override int? Range() => _range;
		public override Constants.Abilities? Save() => _save;

		public override IRoll Damage()
		{
			return new Roll_Base(
				new List<int> { 6, 6 }
			);
		}
		#endregion
		#region private

		#endregion
	}
}