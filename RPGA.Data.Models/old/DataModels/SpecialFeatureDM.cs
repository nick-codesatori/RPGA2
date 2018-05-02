namespace RPGA.Data.Models
{
	public class SpecialFeatureDM : DataModel_Base
	{
		public virtual TC_Feature Name { get; set; }
		public virtual TC_Source Source { get; set; }
	}
}