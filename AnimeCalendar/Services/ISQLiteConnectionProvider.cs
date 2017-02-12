using SQLite;

namespace AnimeCalendar.Services
{
	public interface ISQLiteConnectionProvider
	{
		SQLiteConnection GetConnection();
	}
}