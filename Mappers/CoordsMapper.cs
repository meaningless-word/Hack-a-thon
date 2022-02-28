using AutoMapper;
using DTO;
using Models;

namespace Mappers
{
	public class CoordsMapper : Profile
	{
		public CoordsMapper()
		{
			CreateMap<CoordsModel, CoordsDTO>();
			CreateMap<CoordsDTO, CoordsModel>();
		}
	}
}
