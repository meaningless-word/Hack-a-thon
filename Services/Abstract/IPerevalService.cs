using DTO;

namespace Services.Abstract
{
	public interface IPerevalService
	{
		int AddPereval(PerevalDTO item);
		PerevalDTO GetPerevalById(int id);
	}
}
