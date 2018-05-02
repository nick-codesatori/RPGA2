using RPGA.Common;

namespace RPGA.Logic.Models.Interfaces
{
	public interface IAttack
	{
		string Description();
		int? Range();
		IRoll Attack();
		IRoll Damage();
		Constants.Abilities? Save();
		Constants.AttackShapes? Shape();
		Constants.DamageTypes DamageType();
	}
}