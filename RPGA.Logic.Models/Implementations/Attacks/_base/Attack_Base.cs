using RPGA.Common;
using RPGA.Logic.Models.Interfaces;

namespace RPGA.Logic.Models.Implementations.Attacks
{
	public class Attack_Base : IAttack
	{
		public virtual string Description() => "Default";
		public virtual Constants.DamageTypes DamageType() => Constants.DamageTypes.Bludgeoning;
		public virtual Constants.AttackShapes? Shape() => null; //(int)Constants.AttackShapes.Line;
		public virtual int? Range() => null;
		public virtual Constants.Abilities? Save() => null;
		public virtual IRoll Damage() => null;
		public virtual IRoll Attack() => null;
	}
}