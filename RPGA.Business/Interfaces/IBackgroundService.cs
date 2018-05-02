using RPGA.Logic.Models.Interfaces;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Interfaces
{
	public interface IBackgroundService
	{
		ICharacter AddBackground(ICharacter character, Backgrounds background = Backgrounds.None, LoadTypes loadType = LoadTypes.InitialBuild);
	}
}