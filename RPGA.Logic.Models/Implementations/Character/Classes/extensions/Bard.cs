using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System;
using System.Linq;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Bard : Class_Template
	{
		public Class_Bard(ICharacter character, int level, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			ChangeLevel(level);
			LevelSpecific();
		}

		public override string Class() => EnumHelper<Constants.Classes>.GetDisplayValue(Constants.Classes.Bard);

		private void LevelSpecific()
		{
			switch (Level())
			{
				case 1:
					InitialBenefits();
					AddSpecialFeature(Constants.SpecialFeatures.CharismaCasting);
					AddSpecialFeature(Constants.SpecialFeatures.BardicInspiration);
					break;
				default:
					throw new System.Exception();
			}
		}

		private void InitialBenefits()
		{
			AddSave(Constants.Abilities.Dexterity);
			AddSave(Constants.Abilities.Charisma);
			AddHitDie(8);
			if (InitialBuild)
			{
				AddRandomProficiency(
					Enum.GetValues(typeof(Constants.Skills)).Cast<Constants.Skills>().ToList(),
					3
				);
			}
		}
	}
}