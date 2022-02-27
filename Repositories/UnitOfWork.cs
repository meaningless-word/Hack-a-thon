using Repositories.Abstract;
using System;

namespace Repositories
{
	public class UnitOfWork : IUnitOfWork, IDisposable
	{
		private readonly AppDbContext _context;
		
		public IPerevalAddedRepository Perevals { get; }

		public IPerevalImagesRepository Images { get; }

		public UnitOfWork(AppDbContext context)
		{
			_context = context;

			Perevals = new PerevalAddedRepository(context);
			Images = new PerevalImagesRepository(context);
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
