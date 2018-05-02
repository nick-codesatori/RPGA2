using Microsoft.EntityFrameworkCore;
using RPGA.Data.Models;

namespace RPGA.Data
{
	public class RPGAContext : DbContext
	{
		public RPGAContext(DbContextOptions<RPGAContext> options) : base(options) { }
		//DbContextOptionsBuilder.EnableSensitiveDataLogging
		#region TypeCodes
		//TYPECODES <singular> Plural
		//public DbSet<TC_Size> TC_Sizes { get; set; }
		//public DbSet<TC_Dice> TC_Dice { get; set; }
		//public DbSet<TC_Ability> TC_Abilities { get; set; }
		//public DbSet<TC_DamageType> TC_DamageTypes { get; set; }
		//public DbSet<TC_Shape> TC_Shapes { get; set; }
		//public DbSet<TC_Background> TC_Backgrounds { get; set; }
		//public DbSet<TC_Source> TC_Sources { get; set; }
		//public DbSet<TC_Class> TC_Classes { get; set; }
		//public DbSet<TC_Race> TC_Races { get; set; }
		//public DbSet<TC_Subrace> TC_Subraces { get; set; }
		//public DbSet<TC_Language> TC_Languages { get; set; }
		//public DbSet<TC_DragonType> TC_DragonTypes { get; set; }
		//public DbSet<TC_Feature> TC_Features { get; set; }
		//public DbSet<TC_Skill> TC_Skills { get; set; }
		#endregion
		//DATA MODELS
		//public DbSet<AbilityScoreDM> AbilityScores { get; set; }
		//public DbSet<AttackDM> Attacks { get; set; }
		public DbSet<CharacterDM> Characters { get; set; }
		//public DbSet<SkillsDM> Skills { get; set; }
		//public DbSet<SpecialFeatureDM> SpecialFeatures { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Data Models <singular> .ToPlural
			//modelBuilder.Entity<AbilityScoreDM>().ToTable("AbilityScores");
			modelBuilder.Entity<CharacterDM>();
			//modelBuilder.Entity<SkillsDM>().ToTable("Skills");
			//modelBuilder.Entity<SpecialFeatureDM>();
			//modelBuilder.Entity<AttackDM>().ToTable("Attacks");

			//TypeCodes
			//modelBuilder.Entity<TC_Size>().ToTable("TC_Sizes");
			//modelBuilder.Entity<TC_Dice>().ToTable("TC_Dice");
			//modelBuilder.Entity<TC_Ability>().ToTable("TC_Abilities");
			//modelBuilder.Entity<TC_DamageType>().ToTable("TC_DamageTypes");
			//modelBuilder.Entity<TC_Shape>().ToTable("TC_Shapes");
			//modelBuilder.Entity<TC_Background>().ToTable("TC_Backgrounds");
			//modelBuilder.Entity<TC_Source>().ToTable("TC_Sources");
			//modelBuilder.Entity<TC_Class>().ToTable("TC_Classes");
			//modelBuilder.Entity<TC_Ability>().ToTable("TC_Abilities");
			//modelBuilder.Entity<TC_Skill>().ToTable("TC_Skills");
			//modelBuilder.Entity<TC_DamageType>().ToTable("TC_DamageTypes");
			//modelBuilder.Entity<TC_Race>().ToTable("TC_Races");
			//modelBuilder.Entity<TC_Subrace>().ToTable("TC_Subraces");
			//modelBuilder.Entity<TC_Language>().ToTable("TC_Languages");
			//modelBuilder.Entity<TC_DragonType>().ToTable("TC_DragonTypes");
			//modelBuilder.Entity<TC_Dice>().ToTable("TC_Dice");
			//modelBuilder.Entity<TC_Feature>().ToTable("TC_Features");
		}
	}
}
