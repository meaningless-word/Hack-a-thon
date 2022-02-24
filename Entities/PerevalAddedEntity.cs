using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class PerevalAddedEntity : BaseEntity
	{
		public string RawData { get; set; }
		public string Images { get; set; }
		[MaxLength(20)]
		public string Status { get; set; }
	}
}
