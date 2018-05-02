using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Rogue : Class_Template
	{
		public Class_Rogue(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Rogue);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.SneakAttack);
					AddSpecialFeature(Constants.SpecialFeatures.Expertise);
					AddSpecialFeature(Constants.SpecialFeatures.ThievesCant);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Intelligence);
			AddSave(Constants.Abilities.Dexterity);
			AddHitDie(8);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Acrobatics,
					Constants.Skills.Athletics,
					Constants.Skills.Deception,
					Constants.Skills.Insight,
					Constants.Skills.Intimidation,
					Constants.Skills.Investigation,
					Constants.Skills.Perception,
					Constants.Skills.Performance,
					Constants.Skills.Persuasion,
					Constants.Skills.SleightOfHand,
					Constants.Skills.Stealth,
					},
					4
				);
			}
		}
	}
}