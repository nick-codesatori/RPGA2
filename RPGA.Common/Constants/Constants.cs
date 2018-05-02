using System.ComponentModel.DataAnnotations;

namespace RPGA.Common
{
	public static partial class Constants
	{
		//all simple enums here, other objects in partial
		public enum LoadTypes
		{
			InitialBuild,
			Unpacking
		}

		public enum Sizes
		{
			Small,
			Medium,
			Large
		}

		public enum Backgrounds
		{
			[Display(Name = "None")] None,
			[Display(Name = "Acolyte")] Acolyte,
			[Display(Name = "Charlatan")] Charlatan,
			[Display(Name = "Criminal")] Criminal,
			[Display(Name = "Entertainer")] Entertainer,
			[Display(Name = "Folk Hero")] FolkHero,
			[Display(Name = "Guild Artisan")] GuildArtisan,
			[Display(Name = "Hermit")] Hermit,
			[Display(Name = "Noble")] Noble,
			[Display(Name = "Outlander")] Outlander,
			[Display(Name = "Sage")] Sage,
			[Display(Name = "Sailor")] Sailor,
			[Display(Name = "Soldier")] Soldier,
			[Display(Name = "Urchin")] Urchin,
			[Display(Name = "Random")] Random
		}

		public enum Sources
		{
			None,
			Base,
			Race,
			Class,
			Background
		}

		public enum Classes
		{
			[Display(Name = "None")] None,
			[Display(Name = "Barbarian")] Barbarian,
			[Display(Name = "Bard")] Bard,
			[Display(Name = "Cleric")] Cleric,
			[Display(Name = "Druid")] Druid,
			[Display(Name = "Fighter")] Fighter,
			[Display(Name = "Monk")] Monk,
			[Display(Name = "Paladin")] Paladin,
			[Display(Name = "Ranger")] Ranger,
			[Display(Name = "Rogue")] Rogue,
			[Display(Name = "Sorcerer")] Sorcerer,
			[Display(Name = "Warlock")] Warlock,
			[Display(Name = "Wizard")] Wizard,
			[Display(Name = "Random")] Random,
		}

		public enum Abilities
		{
			Strength,
			Dexterity,
			Constitution,
			Intelligence,
			Wisdom,
			Charisma
		}

		public enum Skills
		{

			[Display(Name = "Athletics")] Athletics,
			[Display(Name = "Acrobatics")] Acrobatics,
			[Display(Name = "Sleight Of Hand")] SleightOfHand,
			[Display(Name = "Stealth")] Stealth,
			[Display(Name = "Arcana")] Arcana,
			[Display(Name = "History")] History,
			[Display(Name = "Investigation")] Investigation,
			[Display(Name = "Nature")] Nature,
			[Display(Name = "Religion")] Religion,
			[Display(Name = "Animal Handling")] AnimalHandling,
			[Display(Name = "Insight")] Insight,
			[Display(Name = "Medicine")] Medicine,
			[Display(Name = "Perception")] Perception,
			[Display(Name = "Survival")] Survival,
			[Display(Name = "Deception")] Deception,
			[Display(Name = "Intimidation")] Intimidation,
			[Display(Name = "Performance")] Performance,
			[Display(Name = "Persuasion")] Persuasion
		}

		public enum DamageTypes
		{
			[Display(Name = "Bludgeoning")] Bludgeoning,
			[Display(Name = "Piercing")] Piercing,
			[Display(Name = "Slashing")] Slashing,
			[Display(Name = "Acid")] Acid,
			[Display(Name = "Lightning")] Lightning,
			[Display(Name = "Fire")] Fire,
			[Display(Name = "Poison")] Poison,
			[Display(Name = "Cold")] Cold,
			[Display(Name = "Necrotic")] Necrotic,
			[Display(Name = "Radiant")] Radiant
		}

		public enum AttackShapes
		{
			[Display(Name = "Cone")] Cone,
			[Display(Name = "Line")] Line,
			[Display(Name = "Sphere")] Sphere,
			[Display(Name = "Cube")] Cube
		}

		public enum Races
		{
			[Display(Name = "Missing")] None,
			[Display(Name = "Aasimar")] Aasimar,
			[Display(Name = "Dragonborn")] Dragonborn,
			[Display(Name = "Dwarf")] Dwarf,
			[Display(Name = "Elf")] Elf,
			[Display(Name = "Firbolg")] Firbolg,
			[Display(Name = "Kenku")] Kenku,
			[Display(Name = "Lizardfolk")] Lizardfolk,
			[Display(Name = "Tabaxi")] Tabaxi,
			[Display(Name = "Gnome")] Gnome,
			[Display(Name = "Goliath")] Goliath,
			[Display(Name = "Half-Elf")] Halfelf,
			[Display(Name = "Half-Orc")] Halforc,
			[Display(Name = "Halfling")] Halfling,
			[Display(Name = "Human")] Human,
			[Display(Name = "Tiefling")] Tiefling,
			[Display(Name = "Triton")] Triton,
			[Display(Name = "Random")] Random
		}

		public enum Subraces
		{
			[Display(Name = "None")] None,
			[Display(Name = "Protector Aasimar")] Aasimar_Protector,
			[Display(Name = "Sourge Aasimar")] Aasimar_Scourge,
			[Display(Name = "Fallen Aasimar")] Aasimar_Fallen,
			[Display(Name = "Duergar")] Dwarf_Duergar,
			[Display(Name = "Hill Dwarf")] Dwarf_Hill,
			[Display(Name = "Mountain Dwarf")] Dwarf_Mountain,
			[Display(Name = "Drow Elf")] Elf_Drow,
			[Display(Name = "High Elf")] Elf_High,
			[Display(Name = "Wood Elf")] Elf_Wood,
			[Display(Name = "Forest Gnome")] Gnome_Forest,
			[Display(Name = "Rock Gnome")] Gnome_Rock,
			[Display(Name = "Lightfoot Halfling")] Halfling_Lightfoot,
			[Display(Name = "Stout Halfling")] Halfling_Stout,
		}

		public enum Languages
		{
			Common,
			Celestial,
			Draconic,
			Dwarvish,
			Undercommon,
			Elvish,
			Gnomish,
			Giant,
			Orc,
			Halfling,
			Auran,
			Infernal,
			Primordial,
			Druidic
		}

		public enum DragonTypes
		{
			[Display(Name = "Black")] Black,
			[Display(Name = "Blue")] Blue,
			[Display(Name = "Brass")] Brass,
			[Display(Name = "Bronze")] Bronze,
			[Display(Name = "Copper")] Copper,
			[Display(Name = "Gold")] Gold,
			[Display(Name = "Green")] Green,
			[Display(Name = "Red")] Red,
			[Display(Name = "Silver")] Silver,
			[Display(Name = "White")] White
		}
	}
}