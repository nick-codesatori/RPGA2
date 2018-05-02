using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Barbarian : Class_Template
	{
		public Class_Barbarian(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Barbarian);

		private void LevelSpecific()
		{
			var level = Level();
			switch (level)
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.BarbarianRage);
					AddSpecialFeature(Constants.SpecialFeatures.BarbarianUnarmoredDefense);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Strength);
			AddSave(Constants.Abilities.Constitution);
			AddHitDie(12);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.AnimalHandling,
					Constants.Skills.Athletics,
					Constants.Skills.Intimidation,
					Constants.Skills.Nature,
					Constants.Skills.Perception,
					Constants.Skills.Survival
					},
					2
				);
			}
		}
	}
}