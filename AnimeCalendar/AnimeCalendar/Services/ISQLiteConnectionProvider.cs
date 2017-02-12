using System;
using SQLite;

namespace AnimeCalendar.Services
{
	public interface ISQLiteConnectionProvider
	{
		SQLiteConnection GetConnection();
	}
}
