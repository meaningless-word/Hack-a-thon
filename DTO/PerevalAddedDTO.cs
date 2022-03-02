using System;

namespace DTO
{
	public class PerevalAddedDTO
	{
		public int Id { get; set; }
		public DateTime DateAdded { get; set; }
		public string RawData { get; set; }
		public string Images { get; set; }
		public string Status { get; set; }
		public PerevalDTO _pereval { get; set; }
		public ImageDTO _images { get; set; }
	}
}
