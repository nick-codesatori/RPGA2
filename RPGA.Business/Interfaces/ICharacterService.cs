using RPGA.Common;
using RPGA.Logic.Models.Interfaces;

namespace RPGA.Logic.Interfaces
{
	public interface ICharacterService
	{
		ICharacter LoadLast();
		ICharacter CreateRandomCharacter(Constants.Races RaceConstraint);
		int[] RandomStatArray();
	}
}