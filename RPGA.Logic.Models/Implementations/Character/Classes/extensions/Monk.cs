using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Monk : Class_Template
	{
		public Class_Monk(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Monk);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.MonkUnarmoredDefense);
					AddSpecialFeature(Constants.SpecialFeatures.MartialArts);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Strength);
			AddSave(Constants.Abilities.Dexterity);
			AddHitDie(8);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Acrobatics,
					Constants.Skills.Athletics,
					Constants.Skills.History,
					Constants.Skills.Insight,
					Constants.Skills.Religion,
					Constants.Skills.Stealth,
					},
					2
				);
			}
		}
	}
}