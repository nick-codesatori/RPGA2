using RPGA.Common;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace RPGA.Logic.Tests
{
	public class Test_Common_RNG_Data : IEnumerable<object[]>
	{
		private readonly List<object[]> _dice = new List<object[]>
		{
			new object[] { 3 },
			new object[] { 4 },
			new object[] { 6 },
			new object[] { 8 },
			new object[] { 10 },
			new object[] { 12 },
			new object[] { 20 },
			new object[] { 100 },
		};

		public IEnumerator<object[]> GetEnumerator() => _dice.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}

	public class Test_Common_RNG
	{
		[Theory]
		[ClassData(typeof(Test_Common_RNG_Data))]
		public void Test_Die_Roll_X1000(int dieType)
		{
			for (var i = 0; i <= 1000; i++)
			{
				var result = RNG.D(dieType);
				Assert.InRange(result, 1, dieType);
			}
		}

		//[Fact]
		//public void TestSkillBonuses()
		//{
		//	var flatScores = new int[] { 10, 10, 10, 10, 10, 10 };
		//	var badDex = new int[] { 10, 9, 10, 10, 10, 10 };
		//	ICharacter newchar;

		//	newchar = new BaseCharacter(flatScores, NoProficiencies());
		//	Assert.Equal(10, newchar.Dexterity());
		//	Assert.Equal(0, Mod(newchar.Dexterity()));
		//	Assert.Equal(0, newchar.Stealth());

		//	newchar = new BaseCharacter(badDex, NoProficiencies());
		//	Assert.Equal(9, newchar.Dexterity());
		//	Assert.Equal(-1, Mod(newchar.Dexterity()));
		//	Assert.Equal(-1, newchar.Stealth());

		//	newchar = new BaseCharacter(flatScores, StealthProficiencies());
		//	Assert.Equal(10, newchar.Dexterity());
		//	Assert.Equal(0, Mod(newchar.Dexterity()));
		//	Assert.Equal(2, newchar.Stealth());

		//	newchar = new BaseCharacter(badDex, StealthProficiencies());
		//	Assert.Equal(9, newchar.Dexterity());
		//	Assert.Equal(-1, Mod(newchar.Dexterity()));
		//	Assert.Equal(1, newchar.Stealth());
		//}

		//private int Mod(int x) => (int)Math.Floor((decimal)(x - 10) / 2);

		//private bool[] NoProficiencies() //18 bool values in array
		//{
		//	bool[] proficiencies = new bool[18];

		//	//proficiencies[(int)Constants.Skills.Stealth] = true;
		//	//proficiencies[(int)Constants.Skills.Intimidation] = true;

		//	return proficiencies;
		//}

		//private bool[] StealthProficiencies() //18 bool values in array
		//{
		//	bool[] proficiencies = new bool[18];

		//	proficiencies[(int)Constants.Skills.Stealth] = true;
		//	//proficiencies[(int)Constants.Skills.Intimidation] = true;

		//	return proficiencies;
		//}
	}

	//ICharacter newchar = new BaseCharacter(RandomStatArray(), TestProficiencies());
}