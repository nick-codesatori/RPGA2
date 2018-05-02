using RPGA.Common;
using RPGA.Logic.Models.Interfaces;

namespace RPGA.Logic.Models.Implementations.Character.Backgrounds
{
	public class Background_Acolyte : Background_Template
	{
		public Background_Acolyte(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Insight);
			AddProficiency(Constants.Skills.Religion);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
		}

		public override string Background() => nameof(Constants.Backgrounds.Acolyte);
	}

	public class Background_Charlatan : Background_Template
	{
		public Background_Charlatan(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Deception);
			AddProficiency(Constants.Skills.SleightOfHand);
		}

		public override string Background() => nameof(Constants.Backgrounds.Charlatan);
	}

	public class Background_Criminal : Background_Template
	{
		public Background_Criminal(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Deception);
			AddProficiency(Constants.Skills.Stealth);
		}

		public override string Background() => nameof(Constants.Backgrounds.Criminal);
	}

	public class Background_Entertainer : Background_Template
	{
		public Background_Entertainer(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Acrobatics);
			AddProficiency(Constants.Skills.Performance);
		}

		public override string Background() => nameof(Constants.Backgrounds.Entertainer);
	}

	public class Background_FolkHero : Background_Template
	{
		public Background_FolkHero(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.AnimalHandling);
			AddProficiency(Constants.Skills.Survival);
		}

		public override string Background() => nameof(Constants.Backgrounds.FolkHero);
	}

	public class Background_GuildArtisan : Background_Template
	{
		public Background_GuildArtisan(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Insight);
			AddProficiency(Constants.Skills.Persuasion);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
		}

		public override string Background() => nameof(Constants.Backgrounds.GuildArtisan);
	}

	public class Background_Hermit : Background_Template
	{
		public Background_Hermit(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Medicine);
			AddProficiency(Constants.Skills.Religion);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
		}

		public override string Background() => nameof(Constants.Backgrounds.Hermit);
	}

	public class Background_Noble : Background_Template
	{
		public Background_Noble(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.History);
			AddProficiency(Constants.Skills.Persuasion);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
		}

		public override string Background() => nameof(Constants.Backgrounds.Noble);
	}

	public class Background_Outlander : Background_Template
	{
		public Background_Outlander(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Athletics);
			AddProficiency(Constants.Skills.Survival);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
		}

		public override string Background() => nameof(Constants.Backgrounds.Outlander);
	}

	public class Background_Sage : Background_Template
	{
		public Background_Sage(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Arcana);
			AddProficiency(Constants.Skills.History);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
		}

		public override string Background() => nameof(Constants.Backgrounds.Sage);
	}

	public class Background_Sailor : Background_Template
	{
		public Background_Sailor(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Athletics);
			AddProficiency(Constants.Skills.Perception);
		}

		public override string Background() => nameof(Constants.Backgrounds.Sailor);
	}

	public class Background_Soldier : Background_Template
	{
		public Background_Soldier(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.Athletics);
			AddProficiency(Constants.Skills.Intimidation);
		}

		public override string Background() => nameof(Constants.Backgrounds.Soldier);
	}

	public class Background_Urchin : Background_Template
	{
		public Background_Urchin(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddProficiency(Constants.Skills.SleightOfHand);
			AddProficiency(Constants.Skills.Stealth);
		}

		public override string Background() => nameof(Constants.Backgrounds.Urchin);
	}
}