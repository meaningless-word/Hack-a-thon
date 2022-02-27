using AutoMapper;
using DTO;
using Models.Pereval;

namespace Mappers
{
	public class PerevalMapper : Profile
	{
		public PerevalMapper()
		{
			CreateMap<AddPerevalRequest, PerevalDTO>();
		}
	}
}
