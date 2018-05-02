using System;

namespace RPGA.Data
{
	public static class ExceptionHelpers
	{
		public static void ThrowIfNotEnum<TEnum>()
			 where TEnum : struct
		{
			if (!typeof(TEnum).IsEnum)
			{
				throw new Exception($"Invalid generic method argument of type {typeof(TEnum)}");
			}
		}
	}
}