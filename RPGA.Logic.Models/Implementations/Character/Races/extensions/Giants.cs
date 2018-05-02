using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Goliath : Race_Template
	{
		public Race_Goliath(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.NaturalAthlete,
				Constants.SpecialFeatures.StonesEndurance,
				Constants.SpecialFeatures.PowerfulBuild, //calculate this when Carry Capacity is a thing
				Constants.SpecialFeatures.MountainBorn,
			});

			AddProficiency(Constants.Skills.Athletics);
			AddLanguage(Constants.Languages.Giant);
		}

		public override string Race() => nameof(Constants.Races.Goliath);
		public override int Strength() => InitialBuild ? component.Strength() + 2 : component.Strength();
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
	}
}