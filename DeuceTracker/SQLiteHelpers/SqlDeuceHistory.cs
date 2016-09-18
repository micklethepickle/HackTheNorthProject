using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DeuceTracker
{
	public static class SqlDeuceHistory
	{
		public static List<DeuceModel> deuceHistory = new List<DeuceModel>();

		public static List<DeuceModel> DeuceHistory
		{
			get { return deuceHistory; }
			set { deuceHistory = value; }
		}

		public static async Task GetDeuceHistoryFromSql()
		{
			DeuceHistory = await App.DeuceRepo.GetDeuceHistoryAsync();
		}
	}
}
