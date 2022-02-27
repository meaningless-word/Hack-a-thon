using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		protected AppDbContext _context;
		internal DbSet<T> dbSet;

		public GenericRepository(AppDbContext context)
		{
			_context = context;
			dbSet = context.Set<T>();
		}

		public virtual int Add(T entity)
		{
			int id = GetLastId() + 1;
			entity.Id = id;
			dbSet.Add(entity);
			return id;
		}

		public virtual T GetItemById(int id)
		{
			return dbSet.FirstOrDefault(x => x.Id == id);
		}

		public virtual IEnumerable<T> GetItems(Expression<Func<T, bool>> predicate)
		{
			return dbSet.Where(predicate).ToList();
		}

		public virtual int Update(T entity)
		{
			throw new NotImplementedException();
		}

		private int GetLastId()
		{
			return dbSet.Count() == 0 ? 0 : dbSet.Max(x => x.Id);
		}
	}
}
