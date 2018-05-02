using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Ranger : Class_Template
	{
		public Class_Ranger(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Ranger);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.FavoredEnemy);
					AddSpecialFeature(Constants.SpecialFeatures.NaturalExplorer);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Strength);
			AddSave(Constants.Abilities.Dexterity);
			AddHitDie(10);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.AnimalHandling,
					Constants.Skills.Athletics,
					Constants.Skills.Insight,
					Constants.Skills.Investigation,
					Constants.Skills.Nature,
					Constants.Skills.Perception,
					Constants.Skills.Stealth,
					Constants.Skills.Survival,
					},
					2
				);
			}
		}
	}
}