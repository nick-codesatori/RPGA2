using RPGA.Common;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Interfaces
{
	public interface ICharacter
	{
		#region Descriptors
		string Race();
		string Background();
		string Class();
		string Size();
		int Speed();
		int Level();
		int? Darkvision();
		int ProficiencyBonus();
		int HP();
		#endregion
		#region Lists
		List<Constants.DamageTypes> Resistances();
		List<Constants.DamageTypes> Vulnerabilities();
		List<Constants.Languages> Languages();
		List<ISpecialFeature> SpecialFeatures();
		List<int> HitDie();
		#endregion
		#region AbilityScores
		Dictionary<Constants.Abilities, int> AbilityScores();
		Dictionary<Constants.Abilities, bool> Saves();
		int Strength();
		int Dexterity();
		int Constitution();
		int Intelligence();
		int Wisdom();
		int Charisma();
		#endregion
		#region Skills
		Dictionary<Constants.Skills, bool> SkillProficiencies();
		//STR
		int Athletics();
		//DEX
		int Acrobatics();
		int SleightOfHand();
		int Stealth();
		//INT
		int Arcana();
		int History();
		int Investigation();
		int Nature();
		int Religion();
		//WIS
		int AnimalHandling();
		int Insight();
		int Medicine();
		int Perception();
		int Survival();
		//CHA
		int Deception();
		int Intimidation();
		int Performance();
		int Persuasion();
		#endregion
		#region Actions
		List<IAttack> Attacks();
		int Mod(int x);
		#endregion
		#region Internal
		void AddLanguage(Constants.Languages x);
		void AddRemoveResistance(Constants.DamageTypes x, bool AddTrue);
		void AddProficiency(Constants.Skills x);
		void AddSpecialFeature(Constants.SpecialFeatures feat, Constants.Sources source);
		void AddSave(Constants.Abilities save);
		void AddHitDie(int d);
		void ChangeProficiencyBonus(int x);
		void ChangeLevel(int x);
		#endregion
	}
}