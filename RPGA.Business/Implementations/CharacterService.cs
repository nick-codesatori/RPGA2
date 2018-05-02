using RPGA.Common;
using RPGA.Data;
using RPGA.Logic.Interfaces;
using RPGA.Logic.Models.Implementations.Character;
using RPGA.Logic.Models.Interfaces;
using System;
using System.Linq;

namespace RPGA.Logic.Implementations
{
	public class CharacterService : ICharacterService
	{
		#region protected
		protected IRaceService RaceService { get; set; }
		protected IBackgroundService BackgroundService { get; set; }
		protected IClassService ClassService { get; set; }
		protected IFlatteningService FlatteningService { get; set; }
		protected RPGAContext _context;

		public CharacterService(IRaceService raceService, IBackgroundService backgroundService, IClassService classService, IFlatteningService flatteningService, RPGAContext context)
		{
			RaceService = raceService;
			BackgroundService = backgroundService;
			ClassService = classService;
			FlatteningService = flatteningService;
			_context = context;
		}
		#endregion

		public ICharacter CreateRandomCharacter(Constants.Races RaceConstraint)
		{
			//Feedback.Log(_context.Characters.ToList().Count.ToString());
			ICharacter newchar = new Character_Base(RandomStatArray(), new bool[18]);
			ICharacter charwithrace;

			if (RaceConstraint != Constants.Races.None)
			{
				charwithrace = RaceService.AddRace(newchar, RaceConstraint);
			}
			else
			{
				charwithrace = RaceService.AddRace(newchar, Constants.Races.Random);
			}

			ICharacter charwithbackground = BackgroundService.AddBackground(charwithrace, Constants.Backgrounds.Random);

			ICharacter charwithclass = ClassService.AddClass(charwithbackground, 1, Constants.Classes.Random);

			FlatteningService.SaveAndFlatten(charwithclass);

			return charwithclass;
		}

		public ICharacter LoadLast()
		{
			var dataModel = _context.Characters.OrderByDescending(c => c.ID).Take(2).Skip(1).FirstOrDefault();
			return FlatteningService.UnflattenCharacter(dataModel);
		}

		/// <summary>
		/// this uses the character creation rules specified in the Darker Dungeons book
		/// </summary>
		/// <returns></returns>
		public int[] RandomStatArray()
		{
			var arrStats = new int[6];

			//roll 3d6 in order
			for (var i = 0; i < 6; i++)
			{
				var roll = RNG.D(6, 3);
				arrStats[i] = roll;
			}

			//reroll lowest, keep higher result
			var lowest = arrStats.Min();
			var reroll = RNG.D(6, 3);

			if (reroll > lowest)
			{
				arrStats[Array.IndexOf(arrStats, lowest)] = reroll;
			}

			return arrStats;
		}
	}
}