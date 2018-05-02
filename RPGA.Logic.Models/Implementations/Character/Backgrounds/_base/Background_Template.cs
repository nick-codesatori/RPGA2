using RPGA.Common;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Backgrounds
{
	public class Background_Template : Character_Template
	{
		public Background_Template(Constants.LoadTypes loadType)
		{
			InitialBuild = (loadType == Constants.LoadTypes.InitialBuild);
		}

		protected bool InitialBuild { get; set; }
		public void AddSpecialFeature(Constants.SpecialFeatures feat) => component.AddSpecialFeature(feat, Constants.Sources.Background);
		public void MassAddSpecialFeatures(List<Constants.SpecialFeatures> feats) => MassAddSpecialFeatures(feats, Constants.Sources.Background);
	}
}