using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repositories.Abstract
{
	public interface IGenericRepository<T> where T : class
	{
		T GetItemById(int id);
		IEnumerable<T> GetItems(Expression<Func<T, bool>> predicate);
		int Add(T entity);
		int Update(T entity);
	}
}
