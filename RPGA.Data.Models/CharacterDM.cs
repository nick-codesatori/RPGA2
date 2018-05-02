namespace RPGA.Data.Models
{
	public class CharacterDM : DataModel_Base
	{
		public string Race { get; set; }
		public string Background { get; set; }
		public string Class { get; set; }
		public string Size { get; set; }
		public int Level { get; set; }
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Constitution { get; set; }
		public int Intelligence { get; set; }
		public int Wisdom { get; set; }
		public int Charisma { get; set; }
		public bool Athletics { get; set; }
		public bool Acrobatics { get; set; }
		public bool SleightOfHand { get; set; }
		public bool Stealth { get; set; }
		public bool Arcana { get; set; }
		public bool History { get; set; }
		public bool Investigation { get; set; }
		public bool Nature { get; set; }
		public bool Religion { get; set; }
		public bool AnimalHandling { get; set; }
		public bool Insight { get; set; }
		public bool Medicine { get; set; }
		public bool Perception { get; set; }
		public bool Survival { get; set; }
		public bool Deception { get; set; }
		public bool Intimidation { get; set; }
		public bool Performance { get; set; }
		public bool Persuasion { get; set; }
	}
}
