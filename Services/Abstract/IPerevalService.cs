using DTO;

namespace Services.Abstract
{
	public interface IPerevalService
	{
		int AddPereval(PerevalDTO item);
		PerevalAddedDTO GetPerevalById(int id);
	}
}
