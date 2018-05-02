using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Druid : Class_Template
	{
		public Class_Druid(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Druid);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.WisdomCasting);
					AddLanguage(Constants.Languages.Druidic);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Wisdom);
			AddSave(Constants.Abilities.Intelligence);
			AddHitDie(8);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Arcana,
					Constants.Skills.AnimalHandling,
					Constants.Skills.Insight,
					Constants.Skills.Medicine,
					Constants.Skills.Nature,
					Constants.Skills.Perception,
					Constants.Skills.Religion,
					Constants.Skills.Survival
					},
					2
				);
			}
		}
	}
}