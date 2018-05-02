using AutoMapper;
using RPGA.Data;
using RPGA.Data.Models;
using RPGA.Logic.Interfaces;
using RPGA.Logic.Models.Implementations.Character;
using RPGA.Logic.Models.Interfaces;
using System;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Implementations
{
	public class FlatteningService : IFlatteningService
	{
		protected IRaceService RaceService;
		protected IBackgroundService BackgroundService;
		protected IClassService ClassService;
		protected RPGAContext _context;

		public FlatteningService(IRaceService raceService, IBackgroundService backgroundService, IClassService classService, RPGAContext context)
		{
			RaceService = raceService;
			BackgroundService = backgroundService;
			ClassService = classService;
			_context = context;
		}

		public void SaveAndFlatten(ICharacter logicalModel)
		{
			var dataModel = FlattenCharacter(logicalModel);

			_context.Characters.Add(dataModel);
			_context.SaveChanges();
		}

		public CharacterDM FlattenCharacter(ICharacter logicalModel)
		{
			return Mapper.Map<ICharacter, CharacterDM>(logicalModel);
		}

		public ICharacter UnflattenCharacter(CharacterDM dataModel)
		{
			ICharacter logicalBase = new Character_Base(
				AbilityScoreArrayFromDM(dataModel),
				ProficiencyArrayFromDM(dataModel)
			);

			ICharacter logicalWithRace = RaceFromString(logicalBase, dataModel.Race);
			ICharacter logicalWithBackground = BackgroundFromString(logicalWithRace, dataModel.Background);
			ICharacter logicalWIthClass = ClassFromString(logicalWithBackground, dataModel.Class);

			return logicalWIthClass;
		}

		private ICharacter RaceFromString(ICharacter character, string Race)
		{
			if (Enum.TryParse(typeof(Subraces), Race, out var mySubRace))
			{
				return RaceService.AddRace(character, Races.None, (Subraces)mySubRace, LoadTypes.Unpacking);
			}
			else
			{
				var race = (Races)Enum.Parse(typeof(Races), Race);
				return RaceService.AddRace(character, race, Subraces.None, LoadTypes.Unpacking);
			}
		}

		private ICharacter BackgroundFromString(ICharacter character, string Background)
		{
			Backgrounds bg = (Backgrounds)Enum.Parse(typeof(Backgrounds), Background);
			return BackgroundService.AddBackground(character, bg, LoadTypes.Unpacking);
		}

		private ICharacter ClassFromString(ICharacter character, string Class)
		{
			Classes _class = (Classes)Enum.Parse(typeof(Classes), Class); //need logic for subraces
			return ClassService.AddClass(character, 1, _class, LoadTypes.Unpacking);
		}

		private bool[] ProficiencyArrayFromDM(CharacterDM dataModel)
		{
			var bSkills = new bool[18];

			bSkills[(int)Skills.Athletics] = dataModel.Athletics;
			bSkills[(int)Skills.Acrobatics] = dataModel.Acrobatics;
			bSkills[(int)Skills.SleightOfHand] = dataModel.SleightOfHand;
			bSkills[(int)Skills.Stealth] = dataModel.Stealth;
			bSkills[(int)Skills.Arcana] = dataModel.Arcana;
			bSkills[(int)Skills.History] = dataModel.History;
			bSkills[(int)Skills.Investigation] = dataModel.Investigation;
			bSkills[(int)Skills.Religion] = dataModel.Religion;
			bSkills[(int)Skills.AnimalHandling] = dataModel.AnimalHandling;
			bSkills[(int)Skills.Insight] = dataModel.Insight;
			bSkills[(int)Skills.Medicine] = dataModel.Medicine;
			bSkills[(int)Skills.Perception] = dataModel.Perception;
			bSkills[(int)Skills.Survival] = dataModel.Survival;
			bSkills[(int)Skills.Deception] = dataModel.Deception;
			bSkills[(int)Skills.Intimidation] = dataModel.Intimidation;
			bSkills[(int)Skills.Performance] = dataModel.Performance;
			bSkills[(int)Skills.Persuasion] = dataModel.Persuasion;

			return new bool[18];
		}

		private int[] AbilityScoreArrayFromDM(CharacterDM dataModel)
		{
			return new int[]
			{
				dataModel.Strength,
				dataModel.Dexterity,
				dataModel.Constitution,
				dataModel.Intelligence,
				dataModel.Wisdom,
				dataModel.Charisma
			};
		}
	}
}