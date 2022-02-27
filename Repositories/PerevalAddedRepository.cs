using Entities;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repositories
{
	public class PerevalAddedRepository : GenericRepository<PerevalAddedEntity>, IPerevalAddedRepository
	{
		public PerevalAddedRepository(AppDbContext context) : base(context)
		{
		}

		public override PerevalAddedEntity GetItemById(int id)
		{
			return base.GetItemById(id);
		}

		public override IEnumerable<PerevalAddedEntity> GetItems(Expression<Func<PerevalAddedEntity, bool>> predicate)
		{
			return base.GetItems(predicate);
		}

		public override int Update(PerevalAddedEntity entity)
		{
			return base.Update(entity);
		}
	}
}
