using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character
{
	public class Character_Template : ICharacter
	{
		protected ICharacter component;

		public void SetComponent(ICharacter _component)
		{
			component = _component;
		}
		#region Descriptors
		public virtual string Race() => component.Race();
		public virtual string Background() => component.Background();
		public virtual string Class() => component.Class();
		public virtual string Size() => component.Size();
		public virtual int Speed() => component.Speed();
		public virtual int ProficiencyBonus() => component.ProficiencyBonus();
		public virtual int? Darkvision() => component.Darkvision();
		public virtual int Level() => component.Level();
		public virtual int HP() => component.HP();
		#endregion
		#region Lists
		public virtual List<Constants.DamageTypes> Resistances() => component.Resistances();
		public virtual List<Constants.DamageTypes> Vulnerabilities() => component.Vulnerabilities();
		public virtual List<Constants.Languages> Languages() => component.Languages();
		public virtual List<ISpecialFeature> SpecialFeatures() => component.SpecialFeatures();
		public virtual List<int> HitDie() => component.HitDie();
		#endregion
		#region AbilityScores
		public virtual Dictionary<Constants.Abilities, int> AbilityScores() => component.AbilityScores();
		public virtual Dictionary<Constants.Abilities, bool> Saves() => component.Saves();
		public virtual int Strength() => component.Strength();
		public virtual int Dexterity() => component.Dexterity();
		public virtual int Constitution() => component.Constitution();
		public virtual int Intelligence() => component.Intelligence();
		public virtual int Wisdom() => component.Wisdom();
		public virtual int Charisma() => component.Charisma();
		#endregion
		#region Skills
		public virtual Dictionary<Constants.Skills, bool> SkillProficiencies() => component.SkillProficiencies();
		//STR
		public int Athletics() => component.Athletics();
		//DEX
		public int Acrobatics() => component.Acrobatics();
		public int SleightOfHand() => component.SleightOfHand();
		public int Stealth() => component.Stealth();
		//INT
		public int Arcana() => component.Arcana();
		public int History() => component.History();
		public int Investigation() => component.Investigation();
		public int Nature() => component.Nature();
		public int Religion() => component.Religion();
		//WIS
		public int AnimalHandling() => component.AnimalHandling();
		public int Insight() => component.Insight();
		public int Medicine() => component.Medicine();
		public int Perception() => component.Perception();
		public int Survival() => component.Survival();
		//CHA
		public int Deception() => component.Deception();
		public int Intimidation() => component.Intimidation();
		public int Performance() => component.Performance();
		public int Persuasion() => component.Persuasion();
		#endregion
		#region Actions
		public List<IAttack> Attacks() => component.Attacks();
		public virtual int Mod(int x) => component.Mod(x);
		#endregion
		#region Internal
		public void ChangeProficiencyBonus(int x) => component.ChangeProficiencyBonus(x);
		public void ChangeLevel(int x) => component.ChangeLevel(x);
		public void AddLanguage(Constants.Languages x) => component.AddLanguage(x);
		public void AddSave(Constants.Abilities save) => component.AddSave(save);
		public void AddRemoveResistance(Constants.DamageTypes x, bool AddTrue) => component.AddRemoveResistance(x, AddTrue);
		public void AddProficiency(Constants.Skills x) => component.AddProficiency(x);
		public void AddSpecialFeature(Constants.SpecialFeatures feat, Constants.Sources source) => component.AddSpecialFeature(feat, source);
		public void AddHitDie(int d) => component.AddHitDie(d);

		public void MassAddSpecialFeatures(List<Constants.SpecialFeatures> feats, Constants.Sources source)
		{
			foreach (Constants.SpecialFeatures feat in feats)
			{
				AddSpecialFeature(feat, source);
			}
		}

		public void RemoveSpecialFeature(Constants.SpecialFeatures feat)
		{
			SpecialFeatures().Remove(SpecialFeatures().Find(f => f.Name() == feat));
		}

		public void AddRandomProficiency(List<Constants.Skills> options)
		{
			var roll = RNG.D(options.Count);
			AddProficiency(options[roll - 1]);
		}

		public void AddRandomProficiency(List<Constants.Skills> options, int num)
		{
			var remainingOptions = options;
			for (var i = 0; i < num; i++)
			{
				var roll = RNG.D(remainingOptions.Count);
				AddProficiency(remainingOptions[roll - 1]);
				remainingOptions.RemoveAt(roll - 1);
			}
		}

		public void AddRandomLanguage(List<Constants.Languages> options)
		{
			var roll = RNG.D(options.Count);
			AddLanguage(options[roll - 1]);
		}

		public void AddRandomSkill(List<Constants.Skills> options)
		{
			var roll = RNG.D(options.Count);
			AddProficiency(options[roll - 1]);
		}
		#endregion
	}
}