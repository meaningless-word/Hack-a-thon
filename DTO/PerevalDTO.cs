using System;

namespace DTO
{
	public class PerevalDTO
	{
		public int pereval_id { get; set; }
		public string beautyTitle { get; set; }
		public string title { get; set; }
		public string other_titles { get; set; }
		public string connect { get; set; }
		public UserDTO user { get; set; }
		public CoordsDTO coords { get; set; }
		public string type { get; set; }
		public LevelDTO level { get; set; }
	}
}
