using System.IO;
using AnimeCalendar.Services;
using SQLite;

namespace AnimeCalendar.Droid.Services
{
	public class SQLiteConnectionProvider : ISQLiteConnectionProvider
	{
		private SQLiteConnection Connection { get; set; }

		public SQLiteConnection GetConnection()
		{
			if (this.Connection != null) { return this.Connection; }

			var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			path = Path.Combine(path, "database.db");
			return this.Connection = new SQLiteConnection(path);
		}
	}
}
