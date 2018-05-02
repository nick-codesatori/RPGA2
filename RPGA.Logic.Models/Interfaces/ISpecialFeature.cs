using RPGA.Common;

namespace RPGA.Logic.Models.Interfaces
{
	public interface ISpecialFeature
	{
		Constants.SpecialFeatures Name();
		Constants.Sources Source();
		string Description();
		string DisplayName();
	}
}