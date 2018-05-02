using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Wizard : Class_Template
	{
		public Class_Wizard(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Wizard);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.IntelligenceCasting);
					AddSpecialFeature(Constants.SpecialFeatures.ArcaneRecovery);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Wisdom);
			AddSave(Constants.Abilities.Intelligence);
			AddHitDie(6);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Arcana,
					Constants.Skills.History,
					Constants.Skills.Insight,
					Constants.Skills.Investigation,
					Constants.Skills.Medicine,
					Constants.Skills.Religion,
					},
					2
				);
			}
		}
	}
}