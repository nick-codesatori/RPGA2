using RPGA.Common;

namespace RPGA.Presentation.Models
{
	public class AttackVM
	{
		public string Description { get; set; }
		public int? Range { get; set; }
		public RollVM Attack { get; set; }
		public RollVM Damage { get; set; }
		public Constants.Abilities? Save { get; set; }
		public Constants.AttackShapes? Shape { get; set; }
		public Constants.DamageTypes DamageType { get; set; }
		public string DamageTypeLabel => EnumHelper<Constants.DamageTypes>.GetDisplayValue(DamageType);
	}
}