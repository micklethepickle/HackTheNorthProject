using SQLite;

namespace DeuceTracker
{
	[Table("DeuceModel")]
	public class DeuceModel
	{

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string TimeOfDeuce { get; set; }
		public string LengthOfDeuce { get; set; }

		public DeuceModel()
		{
		}
	}
}
