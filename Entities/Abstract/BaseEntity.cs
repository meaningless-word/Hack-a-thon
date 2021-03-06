using System;

namespace Entities.Abstract
{
	public abstract class BaseEntity : IBaseEntity
	{
		public int Id { get; set; }
		public DateTime DateAdded { get; set; }
	}
}
