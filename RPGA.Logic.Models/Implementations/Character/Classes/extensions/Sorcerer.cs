using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Sorcerer : Class_Template
	{
		public Class_Sorcerer(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Sorcerer);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.CharismaCasting);
					AddSpecialFeature(Constants.SpecialFeatures.SorcerousOrigin);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Constitution);
			AddSave(Constants.Abilities.Charisma);
			AddHitDie(6);
			if (InitialBuild)
			{
				AddRandomProficiency(
					new List<Constants.Skills>
					{
					Constants.Skills.Arcana,
					Constants.Skills.Deception,
					Constants.Skills.Insight,
					Constants.Skills.Intimidation,
					Constants.Skills.Persuasion,
					Constants.Skills.Religion,
					},
					2
				);
			}
		}
	}
}