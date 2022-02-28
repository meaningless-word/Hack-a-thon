using System.Text.Json.Serialization;

namespace DTO
{
	public class CoordsDTO
	{
		public decimal latitude { get; set; }
		public decimal longitude { get; set; }
		public decimal height { get; set; }
	}
}
