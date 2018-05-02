using RPGA.Common;
using RPGA.Logic.Models.Interfaces;

namespace RPGA.Logic.Models.Implementations.Features
{
	public class SpecialFeature_Base : ISpecialFeature
	{
		private Constants.SpecialFeatures _name { get; }
		private Constants.Sources _source { get; }

		public SpecialFeature_Base(Constants.SpecialFeatures name, Constants.Sources source = Constants.Sources.None)
		{
			_name = name;
			_source = source;
		}

		public Constants.Sources Source() => _source;
		public Constants.SpecialFeatures Name() => _name;
		public string Description() => Constants.SpecialFeaturesDescriptions[Name()];
		public string DisplayName() => EnumHelper<Constants.SpecialFeatures>.GetDisplayValue(Name());
	}
}