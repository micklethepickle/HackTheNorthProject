using System;
namespace DeuceTracker
{
	public class DeuceTrackerModel
	{
		public string CurrentBathroomAction { get; set; }
		public bool SaveButtonEnabled { get; set; }
		public DeuceTrackerModel()
		{
			CurrentBathroomAction = "start";
		}
	}
}
