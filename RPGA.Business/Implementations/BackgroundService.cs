using RPGA.Common;
using RPGA.Logic.Interfaces;
using RPGA.Logic.Models.Implementations.Character.Backgrounds;
using RPGA.Logic.Models.Interfaces;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Implementations
{
	public class BackgroundService : IBackgroundService
	{
		public ICharacter AddBackground(ICharacter character, Backgrounds background = Backgrounds.None, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			switch (background)
			{
				case Backgrounds.Acolyte: return new Background_Acolyte(character, loadType);
				case Backgrounds.Charlatan: return new Background_Charlatan(character, loadType);
				case Backgrounds.Criminal: return new Background_Criminal(character, loadType);
				case Backgrounds.Entertainer: return new Background_Entertainer(character, loadType);
				case Backgrounds.FolkHero: return new Background_FolkHero(character, loadType);
				case Backgrounds.GuildArtisan: return new Background_GuildArtisan(character, loadType);
				case Backgrounds.Hermit: return new Background_Hermit(character, loadType);
				case Backgrounds.Noble: return new Background_Noble(character, loadType);
				case Backgrounds.Outlander: return new Background_Outlander(character, loadType);
				case Backgrounds.Sage: return new Background_Sage(character, loadType);
				case Backgrounds.Sailor: return new Background_Sailor(character, loadType);
				case Backgrounds.Soldier: return new Background_Soldier(character, loadType);
				case Backgrounds.Urchin: return new Background_Urchin(character, loadType);
				case Backgrounds.Random: return RandomDarkerDungeonBackground(character, loadType);
				default:
					throw new System.Exception();
			}
		}

		public ICharacter RandomDarkerDungeonBackground(ICharacter character, LoadTypes loadType)
		{
			switch (RNG.D(100))
			{
				case int n when (n < 7):
					return AddBackground(character, Backgrounds.Acolyte, loadType);
				case int n when (n < 14):
					return AddBackground(character, Backgrounds.Charlatan, loadType);
				case int n when (n < 21):
					return AddBackground(character, Backgrounds.Criminal, loadType);
				case int n when (n < 28):
					return AddBackground(character, Backgrounds.Entertainer, loadType);
				case int n when (n < 35):
					return AddBackground(character, Backgrounds.FolkHero, loadType);
				case int n when (n < 42):
					return AddBackground(character, Backgrounds.GuildArtisan, loadType);
				case int n when (n < 49):
					return AddBackground(character, Backgrounds.Hermit, loadType);
				case int n when (n < 56):
					return AddBackground(character, Backgrounds.Noble, loadType);
				case int n when (n < 63):
					return AddBackground(character, Backgrounds.Outlander, loadType);
				case int n when (n < 70):
					return AddBackground(character, Backgrounds.Sage, loadType);
				case int n when (n < 77):
					return AddBackground(character, Backgrounds.Sailor, loadType);
				case int n when (n < 84):
					return AddBackground(character, Backgrounds.Soldier, loadType);
				case int n when (n < 100):
					return AddBackground(character, Backgrounds.Urchin, loadType);
				default:
					throw new System.InvalidOperationException();
			}
		}
	}
}