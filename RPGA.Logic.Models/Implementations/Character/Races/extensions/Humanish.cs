using RPGA.Common;
using RPGA.Logic.Models.Implementations.Attacks;
using RPGA.Logic.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Races
{
	public class Race_Dragonborn : Race_Template //TODO - add Monstrous Races (bugbear,goblin,hobgoblin,kobold,orc,yuan-ti)
	{
		public Race_Dragonborn(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddSpecialFeature(Constants.SpecialFeatures.DragonbornDamageResistance);

			Constants.DragonTypes randomDragonType = (Constants.DragonTypes)(RNG.D(Enum.GetNames(typeof(Constants.DragonTypes)).Length - 1));
			DragonTypeFeatures(randomDragonType);
		}

		public override string Race() => nameof(Constants.Races.Dragonborn);
		public override int Strength() => InitialBuild ? component.Strength() + 2 : component.Strength();
		public override int Charisma() => InitialBuild ? component.Charisma() + 1 : component.Charisma();

		#region Private
		private void DragonTypeFeatures(Constants.DragonTypes dragonType)
		{
			AddRemoveResistance(DamageTypeFromDragonType(dragonType), true);
			Attacks()
				.Add(
					new Attack_Breath(
						DamageTypeFromDragonType(dragonType),
						ShapeFromDragonType(dragonType),
						SaveFromDragonType(dragonType),
						RangeFromDragonType(dragonType)
					)
				);
		}

		private Constants.DamageTypes DamageTypeFromDragonType(Constants.DragonTypes _dragonType)
		{
			switch (_dragonType)
			{
				case Constants.DragonTypes.Blue:
				case Constants.DragonTypes.Bronze:
					return Constants.DamageTypes.Lightning;
				case Constants.DragonTypes.Copper:
				case Constants.DragonTypes.Black:
					return Constants.DamageTypes.Acid;
				case Constants.DragonTypes.Green:
					return Constants.DamageTypes.Poison;
				case Constants.DragonTypes.Gold:
				case Constants.DragonTypes.Brass:
				case Constants.DragonTypes.Red:
					return Constants.DamageTypes.Fire;
				case Constants.DragonTypes.Silver:
				case Constants.DragonTypes.White:
					return Constants.DamageTypes.Cold;
				default:
					throw new System.InvalidCastException();
			}
		}

		private Constants.AttackShapes ShapeFromDragonType(Constants.DragonTypes _dragonType)
		{
			switch (_dragonType)
			{
				case Constants.DragonTypes.Blue:
				case Constants.DragonTypes.Bronze:
				case Constants.DragonTypes.Copper:
				case Constants.DragonTypes.Black:
				case Constants.DragonTypes.Brass:
					return Constants.AttackShapes.Line;
				case Constants.DragonTypes.Gold:
				case Constants.DragonTypes.Red:
				case Constants.DragonTypes.Green:
				case Constants.DragonTypes.Silver:
				case Constants.DragonTypes.White:
					return Constants.AttackShapes.Cone;
				default:
					throw new System.InvalidCastException();
			}
		}

		private int RangeFromDragonType(Constants.DragonTypes _dragonType)
		{
			switch (_dragonType)
			{
				case Constants.DragonTypes.Blue:
				case Constants.DragonTypes.Bronze:
				case Constants.DragonTypes.Copper:
				case Constants.DragonTypes.Black:
				case Constants.DragonTypes.Brass:
					return 30;
				case Constants.DragonTypes.Gold:
				case Constants.DragonTypes.Red:
				case Constants.DragonTypes.Green:
				case Constants.DragonTypes.Silver:
				case Constants.DragonTypes.White:
					return 15;
				default:
					throw new System.InvalidCastException();
			}
		}

		private Constants.Abilities SaveFromDragonType(Constants.DragonTypes _dragonType)
		{
			switch (_dragonType)
			{
				case Constants.DragonTypes.Blue:
				case Constants.DragonTypes.Bronze:
				case Constants.DragonTypes.Copper:
				case Constants.DragonTypes.Black:
				case Constants.DragonTypes.Brass:
				case Constants.DragonTypes.Gold:
				case Constants.DragonTypes.Red:
					return Constants.Abilities.Dexterity;
				case Constants.DragonTypes.Green:
				case Constants.DragonTypes.Silver:
				case Constants.DragonTypes.White:
					return Constants.Abilities.Constitution;
				default:
					throw new System.InvalidCastException();
			}
		}
		#endregion
	}

	public class Race_Human : Race_Template
	{
		public Race_Human(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			AddSpecialFeature(Constants.SpecialFeatures.BonusLanguage);
			AddSpecialFeature(Constants.SpecialFeatures.HumanAbilityBonus);
		}

		public override string Race() => nameof(Constants.Races.Human);
		public override int Strength() => InitialBuild ? component.Strength() + 1 : component.Strength();
		public override int Dexterity() => InitialBuild ? component.Dexterity() + 1 : component.Dexterity();
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
		public override int Intelligence() => InitialBuild ? component.Intelligence() + 1 : component.Intelligence();
		public override int Wisdom() => InitialBuild ? component.Wisdom() + 1 : component.Wisdom();
		public override int Charisma() => InitialBuild ? component.Charisma() + 1 : component.Charisma();
	}

	public class Race_Halfelf : Race_Template
	{
		public Race_Halfelf(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.FeyAncestry,
				Constants.SpecialFeatures.SkillVersatility,
				Constants.SpecialFeatures.BonusLanguage,
				Constants.SpecialFeatures.HalfelfAbilityBonus
			});

			AddLanguage(Constants.Languages.Elvish);
		}

		public override string Race() => nameof(Constants.Races.Halfelf);
		public override int Charisma() => InitialBuild ? component.Charisma() + 2 : component.Charisma();
		public override int? Darkvision() => 60;
	}

	public class Race_Halforc : Race_Template
	{
		public Race_Halforc(ICharacter character, Constants.LoadTypes lt) : base(lt)
		{
			SetComponent(character);

			MassAddSpecialFeatures(new List<Constants.SpecialFeatures>
			{
				Constants.SpecialFeatures.Menacing,
				Constants.SpecialFeatures.SavageAttacks,
				Constants.SpecialFeatures.RelentlessEndurance,
			});

			AddProficiency(Constants.Skills.Intimidation);
			AddLanguage(Constants.Languages.Orc);
		}

		public override string Race() => nameof(Constants.Races.Halforc);
		public override int Strength() => InitialBuild ? component.Strength() + 2 : component.Strength();
		public override int Constitution() => InitialBuild ? component.Constitution() + 1 : component.Constitution();
		public override int? Darkvision() => 60;
	}
}