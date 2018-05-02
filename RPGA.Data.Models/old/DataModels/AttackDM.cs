using System.Collections.Generic;

namespace RPGA.Data.Models
{
	public class AttackDM : DataModel_Base
	{
		public string Description { get; set; }
		public int? Range { get; set; }

		public virtual ICollection<TC_Dice> AttackDice { get; set; }
		public virtual ICollection<TC_Ability> AttackMods { get; set; }

		public virtual ICollection<TC_Dice> DamageDice { get; set; }
		public virtual ICollection<TC_Ability> DamageMods { get; set; }

		public virtual TC_Ability Save { get; set; }
		public virtual TC_Shape Shape { get; set; }
		public virtual TC_DamageType DamageType { get; set; }
	}
}