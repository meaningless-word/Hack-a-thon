namespace Repositories.Abstract
{
	public interface IUnitOfWork
	{
		IPerevalAddedRepository Perevals { get; }
		IPerevalImagesRepository Images { get; }
		void Commit();
	}
}
