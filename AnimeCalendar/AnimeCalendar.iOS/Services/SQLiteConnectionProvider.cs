using SQLite;
using System;
using System.IO;
using AnimeCalendar.Services;

namespace AnimeCalendar.iOS.Services
{
	public class SQLiteConnectionProvider : ISQLiteConnectionProvider
	{
		private SQLiteConnection Connection { get; set; }

		public SQLiteConnection GetConnection()
		{
			if (this.Connection != null) { return this.Connection; }

			var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			path = Path.Combine(path, "..", "Library", "database.db");
			return this.Connection = new SQLiteConnection(path);
		}
	}
}
