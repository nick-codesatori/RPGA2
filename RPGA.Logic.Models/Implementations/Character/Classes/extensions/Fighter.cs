using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Fighter : Class_Template
	{
		public Class_Fighter(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Fighter);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.FightingStyle);
					AddSpecialFeature(Constants.SpecialFeatures.SecondWind);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Strength);
			AddSave(Constants.Abilities.Constitution);
			AddHitDie(10);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Acrobatics,
					Constants.Skills.AnimalHandling,
					Constants.Skills.Athletics,
					Constants.Skills.History,
					Constants.Skills.Insight,
					Constants.Skills.Intimidation,
					Constants.Skills.Perception,
					Constants.Skills.Survival
					},
					2
				);
			}
		}
	}
}