using RPGA.Common;
using RPGA.Logic.Models.Implementations.Features;
using RPGA.Logic.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character
{
	public class Character_Base : ICharacter //add functions for modifying ability scores at this layer, and replace the race overrides
	{
		protected Dictionary<Constants.Abilities, int> _abilityScores;
		protected Dictionary<Constants.Skills, bool> _skillProficiencies;
		protected Dictionary<Constants.Abilities, bool> _saves;
		protected List<ISpecialFeature> _specialFeatures;
		protected List<Constants.DamageTypes> _resistances;
		protected List<Constants.DamageTypes> _vulnerabilities;
		protected List<Constants.Languages> _languages;
		protected int _proficiencyBonus;
		protected int _level;
		protected List<IAttack> _attacks;
		protected List<int> _hitDie;

		public Character_Base(int[] abilityScores, bool[] skillProficiencies)
		{
			ConstructLists();
			ConstructAbilityScores(abilityScores);
			ConstructSkillProficiencies(skillProficiencies);
			_proficiencyBonus = Constants.Defaults.ProficiencyBonus;
		}

		#region Descriptors
		public string Race() => "Not Yet Selected";
		public string Background() => "Not Yet Selected";
		public string Class() => "Not Yet Selected";
		public string Size() => Constants.Defaults.Size;
		public int Speed() => Constants.Defaults.Speed;
		public int? Darkvision() => Constants.Defaults.Darkvision;
		public int Level() => _level;
		public int HP() => 0;
		public int ProficiencyBonus() => _proficiencyBonus;
		#endregion
		#region Lists
		public List<Constants.DamageTypes> Vulnerabilities() => _vulnerabilities;
		public List<Constants.DamageTypes> Resistances() => _resistances;
		public List<Constants.Languages> Languages() => _languages;
		//public Dictionary<Constants.SpecialFeatures, string> SpecialFeatures() => _specialFeatures;
		public List<ISpecialFeature> SpecialFeatures() => _specialFeatures;
		public List<int> HitDie() => _hitDie;
		#endregion
		#region AbilityScores
		public Dictionary<Constants.Abilities, int> AbilityScores() => _abilityScores;
		public Dictionary<Constants.Abilities, bool> Saves() => _saves;
		public int Strength() => _abilityScores.Count > 0 ? _abilityScores[Constants.Abilities.Strength] : 0;
		public int Dexterity() => _abilityScores.Count > 0 ? _abilityScores[Constants.Abilities.Dexterity] : 0;
		public int Constitution() => _abilityScores.Count > 0 ? _abilityScores[Constants.Abilities.Constitution] : 0;
		public int Intelligence() => _abilityScores.Count > 0 ? _abilityScores[Constants.Abilities.Intelligence] : 0;
		public int Wisdom() => _abilityScores.Count > 0 ? _abilityScores[Constants.Abilities.Wisdom] : 0;
		public int Charisma() => _abilityScores.Count > 0 ? _abilityScores[Constants.Abilities.Charisma] : 0;
		#endregion
		#region Skills
		public Dictionary<Constants.Skills, bool> SkillProficiencies() => _skillProficiencies;
		public int SkillBonus(Constants.Skills skill) => SkillProficiencies()[skill] ? ProficiencyBonus() : 0;
		//STR
		public int Athletics() => SkillBonus(Constants.Skills.Athletics);
		//DEX
		public int Acrobatics() => SkillBonus(Constants.Skills.Acrobatics);
		public int SleightOfHand() => SkillBonus(Constants.Skills.SleightOfHand);
		public int Stealth() => SkillBonus(Constants.Skills.Stealth);
		//INT
		public int Arcana() => SkillBonus(Constants.Skills.Arcana);
		public int History() => SkillBonus(Constants.Skills.History);
		public int Investigation() => SkillBonus(Constants.Skills.Investigation);
		public int Nature() => SkillBonus(Constants.Skills.Nature);
		public int Religion() => SkillBonus(Constants.Skills.Religion);
		//WIS
		public int AnimalHandling() => SkillBonus(Constants.Skills.AnimalHandling);
		public int Insight() => SkillBonus(Constants.Skills.Insight);
		public int Medicine() => SkillBonus(Constants.Skills.Medicine);
		public int Perception() => SkillBonus(Constants.Skills.Perception);
		public int Survival() => SkillBonus(Constants.Skills.Survival);
		//CHA
		public int Deception() => SkillBonus(Constants.Skills.Deception);
		public int Intimidation() => SkillBonus(Constants.Skills.Intimidation);
		public int Performance() => SkillBonus(Constants.Skills.Performance);
		public int Persuasion() => SkillBonus(Constants.Skills.Persuasion);
		#endregion
		#region Actions
		public List<IAttack> Attacks() => _attacks;
		public int Mod(int x) => (int)Math.Floor((decimal)(x - 10) / 2);
		#endregion
		#region Internal
		void ICharacter.ChangeLevel(int x)
		{
			_level = x;
		}

		void ICharacter.ChangeProficiencyBonus(int x)
		{
			_proficiencyBonus = x;
		}

		void ICharacter.AddSpecialFeature(Constants.SpecialFeatures feat, Constants.Sources source)
		{
			SpecialFeatures().Add(
				new SpecialFeature_Base(feat, source)
			);
		}

		void ICharacter.AddSave(Constants.Abilities save)
		{
			Saves()[save] = true;
		}

		void ICharacter.AddLanguage(Constants.Languages x)
		{
			var lst = Languages();

			if (!lst.Contains(x)) lst.Add(x);
		}

		void ICharacter.AddRemoveResistance(Constants.DamageTypes x, bool AddTrue)
		{
			var lst = Resistances();

			if (AddTrue && !lst.Contains(x)) lst.Add(x);
			if (!AddTrue && lst.Contains(x)) lst.Remove(x);
		}

		void ICharacter.AddProficiency(Constants.Skills x)
		{
			SkillProficiencies()[x] = true;
		}

		void ICharacter.AddHitDie(int d)
		{
			_hitDie.Add(d);
		}
		#endregion
		#region Private Methods
		private void ConstructLists()
		{
			_hitDie = new List<int>();
			_attacks = new List<IAttack>();
			_languages = new List<Constants.Languages>();
			_specialFeatures = new List<ISpecialFeature>();
			_resistances = new List<Constants.DamageTypes>();
			_saves = new Dictionary<Constants.Abilities, bool>();
			_vulnerabilities = new List<Constants.DamageTypes>();
			_abilityScores = new Dictionary<Constants.Abilities, int>();
			_skillProficiencies = new Dictionary<Constants.Skills, bool>();
		}

		private void ConstructAbilityScores(int[] scores)
		{
			for (var i = 0; i < Enum.GetNames(typeof(Constants.Abilities)).Length; i++)
			{
				_abilityScores.Add((Constants.Abilities)i, scores[i]);
			}
		}

		private void ConstructSkillProficiencies(bool[] profs)
		{
			for (var i = 0; i < Enum.GetNames(typeof(Constants.Skills)).Length; i++)
			{
				_skillProficiencies.Add((Constants.Skills)i, profs[i]);
			}
		}
		#endregion
	}
}