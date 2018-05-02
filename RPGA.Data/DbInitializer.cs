using RPGA.Common;
using RPGA.Data.Models;

namespace RPGA.Data
{
	public static class DbInitializer
	{
		public static void Initialize(RPGAContext context)
		{
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			/*****************************************************************
			 *  TYPE CODES
			 * **************************************************************/
			//context.TC_Sizes.SeedEnumValues<TC_Size, Constants.Sizes>(@enum => @enum);
			//context.TC_Backgrounds.SeedEnumValues<TC_Background, Constants.Backgrounds>(@enum => @enum);
			//context.TC_Sources.SeedEnumValues<TC_Source, Constants.Sources>(@enum => @enum);
			//context.TC_Classes.SeedEnumValues<TC_Class, Constants.Classes>(@enum => @enum);
			//context.TC_Abilities.SeedEnumValues<TC_Ability, Constants.Abilities>(@enum => @enum);
			//context.TC_Skills.SeedEnumValues<TC_Skill, Constants.Skills>(@enum => @enum);
			//context.TC_DamageTypes.SeedEnumValues<TC_DamageType, Constants.DamageTypes>(@enum => @enum);
			//context.TC_Shapes.SeedEnumValues<TC_Shape, Constants.AttackShapes>(@enum => @enum);
			//context.TC_Races.SeedEnumValues<TC_Race, Constants.Races>(@enum => @enum);
			//context.TC_Subraces.SeedEnumValues<TC_Subrace, Constants.Subraces>(@enum => @enum);
			//context.TC_Languages.SeedEnumValues<TC_Language, Constants.Languages>(@enum => @enum);
			//context.TC_DragonTypes.SeedEnumValues<TC_DragonType, Constants.DragonTypes>(@enum => @enum);
			//context.TC_Features.SeedEnumValues<TC_Feature, Constants.SpecialFeatures>(@enum => @enum);

			//context.TC_Dice.SeedEnumValues<TC_Dice, Constants.Dice>(@enum => @enum);
			//context.SaveChanges();
			/*****************************************************************
			 *  DATA MODELS
			 * **************************************************************/
			//Ability Scores
			//var scores = new AbilityScoreDM[]
			//{
			//	new AbilityScoreDM{
			//		Strength = 10,
			//		Dexterity = 12,
			//		Constitution = 14,
			//		Intelligence = 15,
			//		Wisdom = 16,
			//		Charisma = 18
			//	}
			//};
			//foreach (AbilityScoreDM c in scores)
			//{
			//	context.AbilityScores.Add(c);
			//}
			//context.SaveChanges();
			////Skills
			//var skills = new SkillsDM[]
			//{
			//	new SkillsDM()
			//};
			//foreach (SkillsDM s in skills)
			//{
			//	context.Skills.Add(s);
			//}
			var characters = new CharacterDM[]
			{
				new CharacterDM
				{
					Race = nameof(Constants.Races.Dragonborn),
					Background = nameof(Constants.Backgrounds.Criminal),
					Class = nameof(Constants.Classes.Barbarian),
					Size = nameof(Constants.Sizes.Medium),
					Level = 1,
					Strength = 12, Dexterity = 10, Constitution = 12, Intelligence = 8, Wisdom = 10, Charisma = 12,
					Athletics = true, Intimidation = true
				}
			};
			foreach (CharacterDM character in characters)
			{
				context.Characters.Add(character);
			}
			context.SaveChanges();
		}
	}
}
