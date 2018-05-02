using RPGA.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGA.Presentation.Models
{
	public class CharacterVM
	{
		#region Descriptors
		public string Race { get; set; }
		public string Background { get; set; }
		public string Class { get; set; }
		public string Size { get; set; }
		public int Level { get; set; }
		public string LevelLabel => Level.ToString();
		public int Speed { get; set; }
		public int? Darkvision { get; set; }
		public int ProficiencyBonus { get; set; }

		public int HP()
		{
			int sum = 0;

			HitDie.ForEach(d => sum += d);

			return sum;
		}
		#endregion
		#region Lists
		public List<int> Resistances { get; set; }
		public List<int> Vulnerabilities { get; set; }
		public List<SpecialFeatureVM> SpecialFeatures { get; set; }
		public List<int> HitDie { get; set; }
		public Dictionary<Constants.Skills, bool> SkillProficiencies { get; set; }
		#endregion
		#region AbilityScores
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Constitution { get; set; }
		public int Intelligence { get; set; }
		public int Wisdom { get; set; }
		public int Charisma { get; set; }
		#endregion
		#region Skills
		public int Athletics { get; set; }
		//DEX
		public int Acrobatics { get; set; }
		public int SleightOfHand { get; set; }
		public int Stealth { get; set; }
		//INT
		public int Arcana { get; set; }
		public int History { get; set; }
		public int Investigation { get; set; }
		public int Nature { get; set; }
		public int Religion { get; set; }
		//WIS
		public int AnimalHandling { get; set; }
		public int Insight { get; set; }
		public int Medicine { get; set; }
		public int Perception { get; set; }
		public int Survival { get; set; }
		//CHA
		public int Deception { get; set; }
		public int Intimidation { get; set; }
		public int Performance { get; set; }
		public int Persuasion { get; set; }
		#endregion
		#region Actions
		public List<AttackVM> Attacks { get; set; }

		public string RollAttack(int x)
		{
			var sReturn = String.Empty;

			if (Attacks[x].Attack != null)
			{
				var dice = Attacks[x].Attack.Dice;
				var mods = Attacks[x].Attack.AbilityModifiers;
				int rolledTotal = 0;

				foreach (int d in dice)
				{
					var dieResult = RNG.D(d);
					rolledTotal += dieResult;
					sReturn += $"D{d}({dieResult})";
				}

				if (mods?.Count > 0)
				{
					sReturn += "+";

					foreach (Constants.Abilities a in mods)
					{
						var bonus = AbilityBonus(a);
						rolledTotal += bonus;
						sReturn += $"{a.ToString().Substring(0, 3)}({bonus})";
					}
				}

				sReturn += $"={rolledTotal}";
			}
			return sReturn;
		}

		public string RollDamage(int x)
		{
			var sReturn = String.Empty;

			if (Attacks[x].Damage != null)
			{
				var dice = Attacks[x].Damage.Dice;
				var mods = Attacks[x].Damage.AbilityModifiers;
				int rolledTotal = 0;

				foreach (int d in dice)
				{
					var dieResult = RNG.D(d);
					rolledTotal += dieResult;
					sReturn += $"D{d}({dieResult})";
				}

				if (mods?.Count > 0)
				{
					sReturn += "+";

					foreach (Constants.Abilities a in mods)
					{
						var bonus = AbilityBonus(a);
						rolledTotal += bonus;
						sReturn += $"{a.ToString().Substring(0, 3)}({bonus})";
					}
				}

				sReturn += $"={rolledTotal}";
			}
			return sReturn;
		}
		#endregion
		#region Display Functions
		//Readonly
		public string SourceLabel(Constants.Sources source)
		{
			switch (source)
			{
				case Constants.Sources.Race: return Race;
				case Constants.Sources.Background: return Background;
				case Constants.Sources.Class: return Class;
				default: return "Unknown";
			}
		}

		public int Mod(int x) => (int)Math.Floor((decimal)(x - 10) / 2);
		public string AbilityLabel(int x) => $"{x} ({Mod(x)})";
		public string ResistancesLabel() => Resistances?.Count > 0 ? EnumerableToCSV(Resistances.Select(i => ((Constants.DamageTypes)i).ToString())) : "None";
		public string VulnerabilitiesLabel() => Vulnerabilities?.Count > 0 ? EnumerableToCSV(Vulnerabilities.Select(i => ((Constants.DamageTypes)i).ToString())) : "None";
		public string EnumerableToCSV(IEnumerable<string> input) => string.Join(", ", input);

		public int SkillBonus(Constants.Skills skill)
		{
			int bonus = 0;

			switch (skill)
			{
				case Constants.Skills.Athletics:
					bonus = Mod(Strength) + Athletics;
					break;
				case Constants.Skills.Acrobatics:
					bonus = Mod(Dexterity) + Acrobatics;
					break;
				case Constants.Skills.SleightOfHand:
					bonus = Mod(Dexterity) + SleightOfHand;
					break;
				case Constants.Skills.Stealth:
					bonus = Mod(Dexterity) + Stealth;
					break;
				case Constants.Skills.Arcana:
					bonus = Mod(Intelligence) + Arcana;
					break;
				case Constants.Skills.History:
					bonus = Mod(Intelligence) + History;
					break;
				case Constants.Skills.Investigation:
					bonus = Mod(Intelligence) + Investigation;
					break;
				case Constants.Skills.Nature:
					bonus = Mod(Intelligence) + Nature;
					break;
				case Constants.Skills.Religion:
					bonus = Mod(Intelligence) + Religion;
					break;
				case Constants.Skills.AnimalHandling:
					bonus = Mod(Wisdom) + AnimalHandling;
					break;
				case Constants.Skills.Insight:
					bonus = Mod(Wisdom) + Insight;
					break;
				case Constants.Skills.Medicine:
					bonus = Mod(Wisdom) + Medicine;
					break;
				case Constants.Skills.Perception:
					bonus = Mod(Wisdom) + Perception;
					break;
				case Constants.Skills.Survival:
					bonus = Mod(Wisdom) + Survival;
					break;
				case Constants.Skills.Deception:
					bonus = Mod(Charisma) + Deception;
					break;
				case Constants.Skills.Intimidation:
					bonus = Mod(Charisma) + Intimidation;
					break;
				case Constants.Skills.Performance:
					bonus = Mod(Charisma) + Performance;
					break;
				case Constants.Skills.Persuasion:
					bonus = Mod(Charisma) + Persuasion;
					break;
				default:
					throw new InvalidOperationException();
			}

			return bonus;
		}

		public string BonusLabel(Constants.Skills skill)
		{
			var bonus = SkillBonus(skill);

			return (bonus < 0 ? "" : "+") + bonus.ToString();
		}

		public int AbilityBonus(Constants.Abilities ability)
		{
			switch (ability)
			{
				case Constants.Abilities.Strength: return Mod(Strength);
				case Constants.Abilities.Dexterity: return Mod(Dexterity);
				case Constants.Abilities.Constitution: return Mod(Constitution);
				case Constants.Abilities.Intelligence: return Mod(Intelligence);
				case Constants.Abilities.Wisdom: return Mod(Wisdom);
				case Constants.Abilities.Charisma: return Mod(Charisma);
				default: throw new InvalidCastException();
			}
		}
		#endregion
	}
}