using RPGA.Common;

namespace RPGA.Data.Models
{
	public class TC_Size : EnumTable<Constants.Sizes>
	{
		public TC_Size(Constants.Sizes enumType) : base(enumType) { }
		public TC_Size() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Size(Constants.Sizes enumType) => new TC_Size(enumType);
		public static implicit operator Constants.Sizes(TC_Size status) => status.ID;
	}

	public class TC_Background : EnumTable<Constants.Backgrounds>
	{
		public TC_Background(Constants.Backgrounds enumType) : base(enumType) { }
		public TC_Background() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Background(Constants.Backgrounds enumType) => new TC_Background(enumType);
		public static implicit operator Constants.Backgrounds(TC_Background status) => status.ID;
	}

	public class TC_Shape : EnumTable<Constants.AttackShapes>
	{
		public TC_Shape(Constants.AttackShapes enumType) : base(enumType) { }
		public TC_Shape() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Shape(Constants.AttackShapes enumType) => new TC_Shape(enumType);
		public static implicit operator Constants.AttackShapes(TC_Shape status) => status.ID;
	}

	public class TC_Source : EnumTable<Constants.Sources>
	{
		public TC_Source(Constants.Sources enumType) : base(enumType) { }
		public TC_Source() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Source(Constants.Sources enumType) => new TC_Source(enumType);
		public static implicit operator Constants.Sources(TC_Source status) => status.ID;
	}

	public class TC_Class : EnumTable<Constants.Classes>
	{
		public TC_Class(Constants.Classes enumType) : base(enumType) { }
		public TC_Class() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Class(Constants.Classes enumType) => new TC_Class(enumType);
		public static implicit operator Constants.Classes(TC_Class status) => status.ID;
	}

	public class TC_Ability : EnumTable<Constants.Abilities>
	{
		public TC_Ability(Constants.Abilities enumType) : base(enumType) { }
		public TC_Ability() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Ability(Constants.Abilities enumType) => new TC_Ability(enumType);
		public static implicit operator Constants.Abilities(TC_Ability status) => status.ID;
	}

	public class TC_Skill : EnumTable<Constants.Skills>
	{
		public TC_Skill(Constants.Skills enumType) : base(enumType) { }
		public TC_Skill() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Skill(Constants.Skills enumType) => new TC_Skill(enumType);
		public static implicit operator Constants.Skills(TC_Skill status) => status.ID;
	}

	public class TC_DamageType : EnumTable<Constants.DamageTypes>
	{
		public TC_DamageType(Constants.DamageTypes enumType) : base(enumType) { }
		public TC_DamageType() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_DamageType(Constants.DamageTypes enumType) => new TC_DamageType(enumType);
		public static implicit operator Constants.DamageTypes(TC_DamageType status) => status.ID;
	}

	public class TC_AttackType : EnumTable<Constants.AttackShapes>
	{
		public TC_AttackType(Constants.AttackShapes enumType) : base(enumType) { }
		public TC_AttackType() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_AttackType(Constants.AttackShapes enumType) => new TC_AttackType(enumType);
		public static implicit operator Constants.AttackShapes(TC_AttackType status) => status.ID;
	}

	public class TC_Race : EnumTable<Constants.Races>
	{
		public TC_Race(Constants.Races enumType) : base(enumType) { }
		public TC_Race() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Race(Constants.Races enumType) => new TC_Race(enumType);
		public static implicit operator Constants.Races(TC_Race status) => status.ID;
	}

	public class TC_Subrace : EnumTable<Constants.Subraces>
	{
		public TC_Subrace(Constants.Subraces enumType) : base(enumType) { }
		public TC_Subrace() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Subrace(Constants.Subraces enumType) => new TC_Subrace(enumType);
		public static implicit operator Constants.Subraces(TC_Subrace status) => status.ID;
	}

	public class TC_Language : EnumTable<Constants.Languages>
	{
		public TC_Language(Constants.Languages enumType) : base(enumType) { }
		public TC_Language() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Language(Constants.Languages enumType) => new TC_Language(enumType);
		public static implicit operator Constants.Languages(TC_Language status) => status.ID;
	}

	public class TC_DragonType : EnumTable<Constants.DragonTypes>
	{
		public TC_DragonType(Constants.DragonTypes enumType) : base(enumType) { }
		public TC_DragonType() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_DragonType(Constants.DragonTypes enumType) => new TC_DragonType(enumType);
		public static implicit operator Constants.DragonTypes(TC_DragonType status) => status.ID;
	}

	public class TC_Dice : EnumTable<Constants.Dice>
	{
		public TC_Dice(Constants.Dice enumType) : base(enumType) { }
		public TC_Dice() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Dice(Constants.Dice enumType) => new TC_Dice(enumType);
		public static implicit operator Constants.Dice(TC_Dice status) => status.ID;
	}

	public class TC_Feature : EnumTable<Constants.SpecialFeatures>
	{
		public TC_Feature(Constants.SpecialFeatures enumType) : base(enumType) { }
		public TC_Feature() : base() { } // should excplicitly define for EF!

		public static implicit operator TC_Feature(Constants.SpecialFeatures enumType) => new TC_Feature(enumType);
		public static implicit operator Constants.SpecialFeatures(TC_Feature status) => status.ID;
	}
}