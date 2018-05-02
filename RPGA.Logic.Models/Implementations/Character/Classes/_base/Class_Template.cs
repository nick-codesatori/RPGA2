using RPGA.Common;
using System.Collections.Generic;

namespace RPGA.Logic.Models.Implementations.Character.Classes
{
	public class Class_Template : Character_Template
	{
		public Class_Template(Constants.LoadTypes loadType)
		{
			InitialBuild = (loadType == Constants.LoadTypes.InitialBuild);
		}

		protected bool InitialBuild { get; set; }
		public void AddSpecialFeature(Constants.SpecialFeatures feat) => component.AddSpecialFeature(feat, Constants.Sources.Class);
		public void MassAddSpecialFeatures(List<Constants.SpecialFeatures> feats) => MassAddSpecialFeatures(feats, Constants.Sources.Class);
	}
}