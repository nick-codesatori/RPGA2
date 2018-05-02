using RPGA.Common;

namespace RPGA.Presentation.Models
{
	public class SpecialFeatureVM
	{
		public Constants.SpecialFeatures Name { get; set; }
		public Constants.Sources Source { get; set; }
		public string Description { get; set; }
		public string DisplayName { get; set; }
	}
}