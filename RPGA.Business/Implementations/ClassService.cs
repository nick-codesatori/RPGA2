using RPGA.Common;
using RPGA.Logic.Interfaces;
using RPGA.Logic.Models.Implementations.Character.Classes;
using RPGA.Logic.Models.Interfaces;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Implementations
{
	public class ClassService : IClassService
	{
		public ICharacter AddClass(ICharacter character, int level, Classes newClass = Classes.None, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			switch (newClass)
			{
				case Classes.Barbarian: return new Class_Barbarian(character, level, loadType);
				case Classes.Bard: return new Class_Bard(character, level, loadType);
				case Classes.Cleric: return new Class_Cleric(character, level, loadType);
				case Classes.Druid: return new Class_Druid(character, level, loadType);
				case Classes.Fighter: return new Class_Fighter(character, level, loadType);
				case Classes.Monk: return new Class_Monk(character, level, loadType);
				case Classes.Paladin: return new Class_Paladin(character, level, loadType);
				case Classes.Ranger: return new Class_Ranger(character, level, loadType);
				case Classes.Rogue: return new Class_Rogue(character, level, loadType);
				case Classes.Sorcerer: return new Class_Sorcerer(character, level, loadType);
				case Classes.Warlock: return new Class_Warlock(character, level, loadType);
				case Classes.Wizard: return new Class_Wizard(character, level, loadType);
				case Classes.Random: return RandomDarkerDungeonClass(character, level, loadType);
				default:
					throw new System.Exception();
			}
		}

		public ICharacter RandomDarkerDungeonClass(ICharacter character, int level, LoadTypes loadType)
		{
			switch (RNG.D(100))
			{
				case int n when (n < 8):
					return AddClass(character, level, Classes.Barbarian, loadType);
				case int n when (n < 16):
					return AddClass(character, level, Classes.Bard, loadType);
				case int n when (n < 24):
					return AddClass(character, level, Classes.Cleric, loadType);
				case int n when (n < 32):
					return AddClass(character, level, Classes.Druid, loadType);
				case int n when (n < 40):
					return AddClass(character, level, Classes.Fighter, loadType);
				case int n when (n < 48):
					return AddClass(character, level, Classes.Monk, loadType);
				case int n when (n < 56):
					return AddClass(character, level, Classes.Paladin, loadType);
				case int n when (n < 64):
					return AddClass(character, level, Classes.Ranger, loadType);
				case int n when (n < 72):
					return AddClass(character, level, Classes.Rogue, loadType);
				case int n when (n < 80):
					return AddClass(character, level, Classes.Sorcerer, loadType);
				case int n when (n < 88):
					return AddClass(character, level, Classes.Warlock, loadType);
				case int n when (n < 100):
					return AddClass(character, level, Classes.Wizard, loadType);
				default:
					throw new System.InvalidOperationException();
			}
		}
	}
}