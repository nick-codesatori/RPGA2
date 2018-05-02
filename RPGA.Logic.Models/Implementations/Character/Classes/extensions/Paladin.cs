using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Paladin : Class_Template
	{
		public Class_Paladin(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Paladin);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.DivineSense);
					AddSpecialFeature(Constants.SpecialFeatures.LayOnHands);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Wisdom);
			AddSave(Constants.Abilities.Charisma);
			AddHitDie(10);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Athletics,
					Constants.Skills.Insight,
					Constants.Skills.Intimidation,
					Constants.Skills.Medicine,
					Constants.Skills.Persuasion,
					Constants.Skills.Religion,
					},
					2
				);
			}
		}
	}
}