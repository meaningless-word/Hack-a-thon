using System;

namespace Models.Pereval
{
	public class AddPerevalRequest
	{
		/// <summary>
		/// тип
		/// </summary>
		public string beautyTitle { get; set; }
		public string title { get; set; }
		public string other_titles { get; set; }
		public string connect { get; set; }
		public DateTime  add_time { get; set; }
		public UserModel user { get; set; }
		public CoordsModel coords { get; set; }
		public string type { get; set; }
		public LevelModel level { get; set; }
		public ImageModel[] images { get; set; }
	}
}
