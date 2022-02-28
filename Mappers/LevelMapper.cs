using AutoMapper;
using DTO;
using Models;

namespace Mappers
{
	public class LevelMapper : Profile
	{
		public LevelMapper()
		{
			CreateMap<LevelModel, LevelDTO>();
			CreateMap<LevelDTO, LevelModel>();
		}
	}
}
