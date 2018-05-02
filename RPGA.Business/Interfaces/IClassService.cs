using RPGA.Logic.Models.Interfaces;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Interfaces
{
	public interface IClassService
	{
		ICharacter AddClass(ICharacter character, int level, Classes newClass = Classes.None, LoadTypes loadType = LoadTypes.InitialBuild);
		ICharacter RandomDarkerDungeonClass(ICharacter character, int level, LoadTypes loadType = LoadTypes.InitialBuild);
	}
}