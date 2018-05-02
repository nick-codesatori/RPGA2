using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	//Races
	public class Race_Gnome : Race_Template
	{
		public Race_Gnome(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.GnomeCunning,
			});

			AddLanguage(Constants.Languages.Gnomish);
		}

		public override string Race() => nameof(Constants.Races.Gnome);
		public override int Intelligence() => InitialBuild ? component.Intelligence() + 2 : component.Intelligence();
		public override string Size() => nameof(Constants.Sizes.Small);
		public override int Speed() => 25;
		public override int? Darkvision() => 60;
	}

	public class Race_Halfling : Race_Template
	{
		public Race_Halfling(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.Lucky,
				Constants.SpecialFeatures.Brave,
				Constants.SpecialFeatures.HalflingNimbleness,
			});

			AddLanguage(Constants.Languages.Halfling);
		}

		public override string Race() => nameof(Constants.Races.Halfling);
		public override int Dexterity() => InitialBuild ? component.Dexterity() + 2 : component.Dexterity();
		public override string Size() => nameof(Constants.Sizes.Small);
		public override int Speed() => 25;
	}

	//Subraces
	public class Subrace_Gnome_Forest : Race_Template
	{
		public Subrace_Gnome_Forest(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.NaturalIllusionist,
				Constants.SpecialFeatures.SpeakWithSmallBeasts,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Gnome_Forest);
		public override int Dexterity() => InitialBuild ? component.Dexterity() + 1 : component.Dexterity();
	}

	public class Subrace_Gnome_Rock : Race_Template
	{
		public Subrace_Gnome_Rock(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.ArtificersLore,
				Constants.SpecialFeatures.Tinker,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Gnome_Rock);
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
	}

	public class Subrace_Halfling_Lightfoot : Race_Template
	{
		public Subrace_Halfling_Lightfoot(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.NaturallyStealthy,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Halfling_Lightfoot);
		public override int Charisma() => InitialBuild ? component.Charisma() + 1 : component.Charisma();
	}

	public class Subrace_Halfling_Stout : Race_Template
	{
		public Subrace_Halfling_Stout(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.StoutResilience,
			});
		}

		public override string Race() => nameof(Constants.Subraces.Halfling_Stout);
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
	}
}