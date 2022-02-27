using AutoMapper;
using DTO;
using Entities;
using Models.Pereval;

namespace Mappers
{
	public class PerevalMapper : Profile
	{
		public PerevalMapper()
		{
			CreateMap<AddPerevalRequest, PerevalDTO>();
			CreateMap<PerevalDTO, PerevalAddedEntity>()
				.ForMember(x => x.DateAdded, opt => opt.MapFrom(src => src.add_time));
		}
	}
}
