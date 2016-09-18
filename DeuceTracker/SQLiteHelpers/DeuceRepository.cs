using SQLite;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DeuceTracker
{
	public class DeuceRepository
	{
		private readonly SQLiteAsyncConnection conn;

		public DeuceRepository(string dbpath)
		{
			conn = new SQLiteAsyncConnection(dbpath);
			conn.CreateTableAsync<DeuceModel>().Wait();
		}

		public async Task AddNewDeuceAsync(string timeOfDeuce, string lengthOfDeuce)
		{
			await conn.InsertAsync(new DeuceModel
			{
				TimeOfDeuce = timeOfDeuce,
				LengthOfDeuce = lengthOfDeuce
			});
		}

		public async Task<List<DeuceModel>> GetDeuceHistoryAsync()
		{
			return await conn.Table<DeuceModel>().ToListAsync();
		}

		public async Task ClearDeuceHistoryAsync()
		{
			await conn.RunInTransactionAsync(connection =>
			{
				connection.Execute($"DELETE FROM [DeuceModel]");
			});
		}
	}
}
