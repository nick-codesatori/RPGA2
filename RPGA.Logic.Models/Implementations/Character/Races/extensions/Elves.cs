using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Elf : Race_Template
	{
		public Race_Elf(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Perception);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.FeyAncestry,
				Constants.SpecialFeatures.Trance
			});

			AddLanguage(Constants.Languages.Elvish);
		}

		public override string Race() => nameof(Constants.Races.Elf);
		public override int Dexterity() => InitialBuild ? component.Dexterity() + 2 : component.Dexterity();
		public override int? Darkvision() => 60;
	}

	public class Subrace_Elf_Drow : Race_Template
	{
		public Subrace_Elf_Drow(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.DrowWeaponTraining,
				Constants.SpecialFeatures.SunlightSensitivity,
				Constants.SpecialFeatures.DrowMagic,
			});

			AddLanguage(Constants.Languages.Undercommon);
		}

		public override string Race() => nameof(Constants.Subraces.Elf_Drow);
		public override int Charisma() => InitialBuild ? component.Charisma() + 1 : component.Charisma();
	}

	public class Subrace_Elf_High : Race_Template
	{
		public Subrace_Elf_High(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.BonusLanguage,
				Constants.SpecialFeatures.ElfWeaponTraining,
				Constants.SpecialFeatures.ElfCantrip,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Elf_High);
		public override int Intelligence() => InitialBuild ? component.Intelligence() + 1 : component.Intelligence();
	}

	public class Subrace_Elf_Wood : Race_Template
	{
		public Subrace_Elf_Wood(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.FleetOfFoot,
				Constants.SpecialFeatures.ElfWeaponTraining,
				Constants.SpecialFeatures.MaskOfTheWild,
			});
		}

		public override int Speed() => 35;
		public override string Race() => nameof(Constants.Subraces.Elf_Wood);
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 1 : component.Wisdom();
	}
}