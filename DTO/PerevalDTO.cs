using System;

namespace DTO
{
	public class PerevalDTO
	{
		public int id { get; set; }
		public string beautyTitle { get; set; }
		public string title { get; set; }
		public string other_titles { get; set; }
		public string connect { get; set; }
		public DateTime add_time { get; set; }
		public UserDTO user { get; set; }
		public CoordsDTO coords { get; set; }
		public string type { get; set; }
		public LevelDTO level { get; set; }
		public ImageDTO[] images { get; set; }
	}
}
