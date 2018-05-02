using RPGA.Common;
using RPGA.Logic.Interfaces;
using RPGA.Logic.Models.Implementations.Character.Races;
using RPGA.Logic.Models.Interfaces;
using static RPGA.Common.Constants;

namespace RPGA.Logic.Implementations
{
	public class RaceService : IRaceService
	{
		public ICharacter AddRace(ICharacter character, Races race = Races.None, Subraces subrace = Subraces.None, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			if (subrace != Subraces.None)
			{
				switch (subrace)
				{
					case Subraces.Aasimar_Fallen: return new Subrace_Aasimar_Fallen(new Race_Aasimar(character, loadType), loadType);
					case Subraces.Aasimar_Protector: return new Subrace_Aasimar_Protector(new Race_Aasimar(character, loadType), loadType);
					case Subraces.Aasimar_Scourge: return new Subrace_Aasimar_Scourge(new Race_Aasimar(character, loadType), loadType);
					case Subraces.Elf_Drow: return new Subrace_Elf_Drow(new Race_Elf(character, loadType), loadType);
					case Subraces.Elf_High: return new Subrace_Elf_High(new Race_Elf(character, loadType), loadType);
					case Subraces.Elf_Wood: return new Subrace_Elf_Wood(new Race_Elf(character, loadType), loadType);
					case Subraces.Dwarf_Hill: return new Subrace_Dwarf_Hill(new Race_Dwarf(character, loadType), loadType);
					case Subraces.Dwarf_Mountain: return new Subrace_Dwarf_Mountain(new Race_Dwarf(character, loadType), loadType);
					case Subraces.Gnome_Forest: return new Subrace_Gnome_Forest(new Race_Gnome(character, loadType), loadType);
					case Subraces.Gnome_Rock: return new Subrace_Gnome_Rock(new Race_Gnome(character, loadType), loadType);
					case Subraces.Halfling_Lightfoot: return new Subrace_Halfling_Lightfoot(new Race_Halfling(character, loadType), loadType);
					case Subraces.Halfling_Stout: return new Subrace_Halfling_Stout(new Race_Halfling(character, loadType), loadType);
					default:
						throw new System.Exception();
				}
			}
			else
			{
				switch (race)
				{
					case Races.Random: return RandomDarkerDungeonRace(character, loadType);
					case Races.Aasimar: return RandomAasimar(character, loadType);
					case Races.Dwarf: return RandomDwarf(character, loadType);
					case Races.Elf: return RandomElf(character, loadType);
					case Races.Gnome: return RandomGnome(character, loadType);
					case Races.Halfling: return RandomHalfling(character, loadType);
					case Races.Firbolg: return new Race_Firbolg(character, loadType);
					case Races.Goliath: return new Race_Goliath(character, loadType);
					case Races.Dragonborn: return new Race_Dragonborn(character, loadType);
					case Races.Halfelf: return new Race_Halfelf(character, loadType);
					case Races.Halforc: return new Race_Halforc(character, loadType);
					case Races.Human: return new Race_Human(character, loadType);
					case Races.Kenku: return new Race_Kenku(character, loadType);
					case Races.Lizardfolk: return new Race_Lizardfolk(character, loadType);
					case Races.Tabaxi: return new Race_Tabaxi(character, loadType);
					case Races.Triton: return new Race_Triton(character, loadType);
					case Races.Tiefling: return new Race_Tiefling(character, loadType);
					default:
						throw new System.Exception();
				}
			}
		}

		private ICharacter RandomDarkerDungeonRace(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			var roll = RNG.D(100);
			switch (roll)
			{
				case int n when (n <= 1): return RandomAasimar(character, loadType);
				case int n when (n <= 4): return AddRace(character, Races.Dragonborn, Subraces.None, loadType);
				case int n when (n <= 19): return RandomDwarf(character, loadType);
				case int n when (n <= 29): return RandomElf(character, loadType);
				case int n when (n <= 31): return AddRace(character, Races.Firbolg, Subraces.None, loadType);
				case int n when (n <= 37): return RandomGnome(character, loadType);
				case int n when (n <= 39): return AddRace(character, Races.Goliath, Subraces.None, loadType);
				case int n when (n <= 40): return AddRace(character, Races.Halfelf, Subraces.None, loadType);
				case int n when (n <= 41): return AddRace(character, Races.Halforc, Subraces.None, loadType);
				case int n when (n <= 48): return RandomHalfling(character, loadType);
				case int n when (n <= 90): return AddRace(character, Races.Human, Subraces.None, loadType);
				case int n when (n <= 91): return AddRace(character, Races.Kenku, Subraces.None, loadType);
				case int n when (n <= 92): return AddRace(character, Races.Lizardfolk, Subraces.None, loadType);
				case int n when (n <= 94): return AddRace(character, Races.Tabaxi, Subraces.None, loadType);
				case int n when (n <= 98): return AddRace(character, Races.Tiefling, Subraces.None, loadType);
				case int n when (n < 100): return AddRace(character, Races.Triton, Subraces.None, loadType);
				default:
					throw new System.Exception();
			}
		}

		private ICharacter RandomAasimar(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			var roll = RNG.D(100);

			switch (roll)
			{
				case int n when (n <= 33): return AddRace(character, Races.Aasimar, Subraces.Aasimar_Fallen, loadType);
				case int n when (n <= 67): return AddRace(character, Races.Aasimar, Subraces.Aasimar_Protector, loadType);
				case int n when (n <= 100): return AddRace(character, Races.Aasimar, Subraces.Aasimar_Scourge, loadType);
				default:
					throw new System.Exception();
			}
		}

		private ICharacter RandomDwarf(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			var roll = RNG.D(100);

			switch (roll)
			{
				case int n when (n <= 50): return AddRace(character, Races.Dwarf, Subraces.Dwarf_Hill, loadType);
				case int n when (n <= 100): return AddRace(character, Races.Dwarf, Subraces.Dwarf_Mountain, loadType);
				default:
					throw new System.Exception();
			}
		}

		private ICharacter RandomElf(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			var roll = RNG.D(100);

			switch (roll)
			{
				case int n when (n <= 10): return AddRace(character, Races.Elf, Subraces.Elf_Drow, loadType);
				case int n when (n <= 55): return AddRace(character, Races.Elf, Subraces.Elf_High, loadType);
				case int n when (n <= 100): return AddRace(character, Races.Elf, Subraces.Elf_Wood, loadType);
				default:
					throw new System.Exception();
			}
		}

		private ICharacter RandomGnome(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			var roll = RNG.D(100);

			switch (roll)
			{
				case int n when (n <= 50): return AddRace(character, Races.Gnome, Subraces.Gnome_Forest, loadType);
				case int n when (n <= 100): return AddRace(character, Races.Gnome, Subraces.Gnome_Rock, loadType);
				default:
					throw new System.Exception();
			}
		}

		private ICharacter RandomHalfling(ICharacter character, LoadTypes loadType = LoadTypes.InitialBuild)
		{
			var roll = RNG.D(100);

			switch (roll)
			{
				case int n when (n <= 50): return AddRace(character, Races.Halfling, Subraces.Halfling_Lightfoot, loadType);
				case int n when (n <= 100): return AddRace(character, Races.Halfling, Subraces.Halfling_Stout, loadType);
				default:
					throw new System.Exception();
			}
		}
	}
}