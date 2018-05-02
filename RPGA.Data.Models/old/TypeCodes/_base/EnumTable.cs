namespace RPGA.Data.Models
{
	public abstract class EnumTable<TEnum> where TEnum : struct
	{
		public TEnum ID { get; set; }
		public string Value { get; set; }

		protected EnumTable() { }

		protected EnumTable(TEnum enumType)
		{
			ExceptionHelpers.ThrowIfNotEnum<TEnum>();

			ID = enumType;
			Value = enumType.ToString();
		}

		//public static implicit operator EnumTable<TEnum>(TEnum enumType) => new EnumTable<TEnum>(enumType);
		//public static implicit operator TEnum(EnumTable<TEnum> status) => status.ID;
	}
}