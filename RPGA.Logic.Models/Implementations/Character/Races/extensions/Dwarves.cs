using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Dwarf : Race_Template
	{
		public Race_Dwarf(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.DwarvenResilience,
				Constants.SpecialFeatures.DwarvenCombatTraining,
				Constants.SpecialFeatures.Stonecunning,
			});

			AddLanguage(Constants.Languages.Dwarvish);
		}

		public override string Race() => nameof(Constants.Races.Dwarf);
		public override int Constitution() => InitialBuild ? component.Constitution() + 2 : component.Constitution();
		public override int Speed() => 25;
		public override int? Darkvision() => 60;
	}

	public class Subrace_Dwarf_Duergar : Race_Template
	{
		public Subrace_Dwarf_Duergar(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.DuergarMagic,
				Constants.SpecialFeatures.SunlightSensitivity
			});

			AddLanguage(Constants.Languages.Undercommon);
		}

		public override int? Darkvision() => 120; //Superior Darkvision
		public override string Race() => nameof(Constants.Subraces.Dwarf_Duergar);
		public override int Strength() => InitialBuild ? component.Strength() + 1 : component.Strength();
	}

	public class Subrace_Dwarf_Hill : Race_Template
	{
		public Subrace_Dwarf_Hill(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.DwarvenToughness,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Dwarf_Hill);
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 1 : component.Wisdom();
		public override int HP() => InitialBuild ? component.HP() + Level() : component.HP();
	}

	public class Subrace_Dwarf_Mountain : Race_Template
	{
		public Subrace_Dwarf_Mountain(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.DwarvenArmorTraining,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Dwarf_Mountain);
		public override int Strength() => InitialBuild ? component.Strength() + 2 : component.Strength();
	}
}