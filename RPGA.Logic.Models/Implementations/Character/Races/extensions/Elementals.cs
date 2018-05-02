using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Triton : Race_Template
	{
		public Race_Triton(ICharacter character, Constants.LoadTypes loadType) : base(loadType)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.Amphibious,
				Constants.SpecialFeatures.ControlAirAndWater,
				Constants.SpecialFeatures.EmissaryOfTheSea,
				Constants.SpecialFeatures.GuardiansOfTheDepths,
			});

			AddLanguage(Constants.Languages.Primordial);
		}

		public override string Race() => nameof(Constants.Races.Triton);
		public override int Strength() => InitialBuild ? component.Strength() + 1 : component.Strength();
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
		public override int Charisma() => InitialBuild ? component.Charisma() + 1 : component.Charisma();
	}
}