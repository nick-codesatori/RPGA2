using RPGA.Logic.Models.Interfaces;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Interfaces
{
	public interface IRaceService
	{
		ICharacter AddRace(ICharacter character, Races race = Races.None, Subraces subrace = Subraces.None, LoadTypes loadType = LoadTypes.InitialBuild);
		//ICharacter RandomAasimar(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild);
		//ICharacter RandomDarkerDungeonRace(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild);
		//ICharacter RandomDwarf(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild);
		//ICharacter RandomElf(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild);
		//ICharacter RandomGnome(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild);
		//ICharacter RandomHalfling(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild);
	}
}