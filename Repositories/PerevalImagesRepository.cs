using Entities;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repositories
{
	public class PerevalImagesRepository : GenericRepository<PerevalImagesEntity>, IPerevalImagesRepository
	{
		public PerevalImagesRepository(AppDbContext context) : base(context)
		{
		}

		public override PerevalImagesEntity GetItemById(int id)
		{
			return base.GetItemById(id);
		}

		public override IEnumerable<PerevalImagesEntity> GetItems(Expression<Func<PerevalImagesEntity, bool>> predicate)
		{
			return base.GetItems(predicate);
		}
	}
}
