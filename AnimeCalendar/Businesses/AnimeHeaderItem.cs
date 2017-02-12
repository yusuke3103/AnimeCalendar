using SQLite;

namespace AnimeCalendar
{
	public class AnimeHeaderItem
	{
		/// <summary>
		/// アニメID
		/// </summary>
		/// <value>The anime identifier.</value>
		[PrimaryKey, AutoIncrement]
		public int AnimeId { get; set; }
		/// <summary>
		/// タイトル
		/// </summary>
		/// <value>The title.</value>
		[NotNull]
		public string Title { get; set; }

	}
}
