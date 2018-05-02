using RPGA.Data.Models;
using RPGA.Logic.Models.Interfaces;

namespace RPGA.Logic.Interfaces
{
	public interface IFlatteningService
	{
		void SaveAndFlatten(ICharacter logicalModel);
		CharacterDM FlattenCharacter(ICharacter logicalModel);
		ICharacter UnflattenCharacter(CharacterDM dataModel);
	}
}