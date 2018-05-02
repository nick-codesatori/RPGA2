using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Aasimar : Race_Template
	{
		public Race_Aasimar(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);
			CelestialResistance();

			AddSpecialFeature(Constants.SpecialFeatures.HealingHands);

			AddLanguage(Constants.Languages.Common);
			AddLanguage(Constants.Languages.Celestial);
		}

		public override string Race() => nameof(Constants.Races.Aasimar);
		public override int Charisma() => InitialBuild ? component.Charisma() + 2 : component.Charisma();

		private void CelestialResistance()
		{
			AddRemoveResistance(Constants.DamageTypes.Necrotic, true);
			AddRemoveResistance(Constants.DamageTypes.Radiant, true);
		}
	}

	public class Subrace_Aasimar_Protector : Race_Template
	{
		public Subrace_Aasimar_Protector(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddSpecialFeature(Constants.SpecialFeatures.RadiantSoul);
		}

		public override string Race() => nameof(Constants.Subraces.Aasimar_Protector);
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 1 : component.Wisdom();
	}

	public class Subrace_Aasimar_Scourge : Race_Template
	{
		public Subrace_Aasimar_Scourge(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddSpecialFeature(Constants.SpecialFeatures.RadiantConsumption);
		}

		public override string Race() => nameof(Constants.Subraces.Aasimar_Scourge);
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
	}

	public class Subrace_Aasimar_Fallen : Race_Template
	{
		public Subrace_Aasimar_Fallen(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddSpecialFeature(Constants.SpecialFeatures.NecroticShroud);
		}

		public override string Race() => nameof(Constants.Subraces.Aasimar_Fallen);
		public override int Strength() => InitialBuild ? component.Strength() + 1 : component.Strength();
	}

	public class Race_Tiefling : Race_Template
	{
		public Race_Tiefling(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.HellishResistance,
				Constants.SpecialFeatures.InfernalLegacy
			});

			AddRemoveResistance(Constants.DamageTypes.Fire, true);
			AddLanguage(Constants.Languages.Infernal);
		}

		public override string Race() => nameof(Constants.Races.Tiefling);
		public override int Intelligence() => InitialBuild ? component.Intelligence() + 1 : component.Intelligence();
		public override int Charisma() => InitialBuild ? component.Charisma() + 2 : component.Charisma();
	}
}