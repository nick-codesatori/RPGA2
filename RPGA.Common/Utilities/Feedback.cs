using System.Diagnostics;

namespace RPGA.Common
{
	public static class Feedback
	{
		public static void Log(string s)
		{
			Debug.WriteLine("#RPGA" + s);
		}
	}
}