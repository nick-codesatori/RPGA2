using System;
using System.ComponentModel.DataAnnotations;

namespace RPGA.Common
{
	public static class RNG
	{
		private static Random _generator;

		public static Random Generator => _generator ?? (_generator = new Random());
		public static int D(int die) => (int)Math.Floor((decimal)Generator.Next(1, die));

		public static int D(int die, int quantity)
		{
			int sum = 0;
			for (var i = 0; i < quantity; i++)
			{
				sum += D(die);
			}
			return sum;
		}
	}
}