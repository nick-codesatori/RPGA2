using RPGA.Common;
using RPGA.Logic.Models.Implementations.Attacks;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Firbolg : Race_Template
	{
		public Race_Firbolg(ICharacter character, Constants.LoadTypes loadType) : base(loadType)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.FirbolgMagic,
				Constants.SpecialFeatures.HiddenStep,
				Constants.SpecialFeatures.PowerfulBuild,
				Constants.SpecialFeatures.SpeechOfBeastAndLeaf,
			});

			AddLanguage(Constants.Languages.Elvish);
			AddLanguage(Constants.Languages.Giant);
		}

		public override string Race() => nameof(Constants.Races.Firbolg);
		public override int Strength() => InitialBuild ? component.Strength() + 1 : component.Strength();
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 2 : component.Wisdom();
	}

	public class Race_Kenku : Race_Template
	{
		public Race_Kenku(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.ExpertForgery,
				Constants.SpecialFeatures.KenkuTraining,
				Constants.SpecialFeatures.Mimicry,
			});

			AddLanguage(Constants.Languages.Auran);
		}

		public override string Race() => nameof(Constants.Races.Kenku);
		public override int Dexterity() => InitialBuild ? component.Dexterity() + 2 : component.Dexterity();
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 1 : component.Wisdom();
	}

	public class Race_Lizardfolk : Race_Template
	{
		public Race_Lizardfolk(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.LizardfolkNaturalArmor,
				Constants.SpecialFeatures.LizardfolkBiteAttack,
				Constants.SpecialFeatures.HoldBreath,
				Constants.SpecialFeatures.CunningArtisan,
				Constants.SpecialFeatures.HuntersLore,
				Constants.SpecialFeatures.HungryJaws,
			});

			LizardfolkBiteAttack();
			AddLanguage(Constants.Languages.Draconic);
		}

		public override string Race() => nameof(Constants.Races.Lizardfolk);
		public override int Constitution() => InitialBuild ? component.Constitution() + 2 : component.Constitution();
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 1 : component.Wisdom();

		private void LizardfolkBiteAttack()
		{
			Attacks().Add(new Attack_Bite());
		}
	}

	public class Race_Tabaxi : Race_Template
	{
		public Race_Tabaxi(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.FelineAgility,
				Constants.SpecialFeatures.CatsClaws,
				Constants.SpecialFeatures.CatsTalent,
				Constants.SpecialFeatures.BonusLanguage
			});

			AddProficiency(Constants.Skills.Perception);
			AddProficiency(Constants.Skills.Stealth);

			TabaxiClawAttack();
		}

		public override int? Darkvision() => 60;
		public override string Race() => nameof(Constants.Races.Tabaxi);
		public override int Dexterity() => InitialBuild ? component.Dexterity() + 2 : component.Dexterity();
		public override int Charisma() => InitialBuild ? component.Charisma() + 1 : component.Charisma();

		private void TabaxiClawAttack()
		{
			Attacks().Add(new Attack_Claw());
		}
	}
}