using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Warlock : Class_Template
	{
		public Class_Warlock(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Warlock);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.OtherworldlyPatron);
					AddSpecialFeature(Constants.SpecialFeatures.PactMagic);
					AddSpecialFeature(Constants.SpecialFeatures.CharismaCasting);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Wisdom);
			AddSave(Constants.Abilities.Charisma);
			AddHitDie(8);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Arcana,
					Constants.Skills.Deception,
					Constants.Skills.History,
					Constants.Skills.Intimidation,
					Constants.Skills.Investigation,
					Constants.Skills.Nature,
					Constants.Skills.Religion,
					},
					2
				);
			}
		}
	}
}