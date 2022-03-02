using AutoMapper;
using DTO;
using Entities;
using Models.Pereval;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mappers
{
	public class PerevalAddedMapper : Profile
	{
		public PerevalAddedMapper()
		{
			CreateMap<PerevalAddedEntity, PerevalAddedDTO>()
				.ForMember(x => x._pereval, opt => opt.MapFrom(src => JsonSerializer.Deserialize<PerevalDTO>(src.RawData, 
				new JsonSerializerOptions() { NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString}
				)))
				.ForMember(x => x._images, opt => opt.MapFrom(src => JsonSerializer.Deserialize<ImageDTO>(src.Images,
				new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }
				)))
				;
			CreateMap<PerevalAddedDTO, GetPerevalResponse>()
				.ForMember(x => x.id, opt => opt.MapFrom(src => src.Id))
				.ForMember(x => x.pereval_id, opt => opt.MapFrom(src => src._pereval.pereval_id))
				.ForMember(x => x.beautyTitle, opt => opt.MapFrom(src => src._pereval.beautyTitle))
				.ForMember(x => x.title, opt => opt.MapFrom(src => src._pereval.title))
				.ForMember(x => x.other_titles, opt => opt.MapFrom(src => src._pereval.other_titles))
				.ForMember(x => x.connect, opt => opt.MapFrom(src => src._pereval.connect))
				.ForMember(x => x.user, opt => opt.MapFrom(src => src._pereval.user))
				.ForMember(x => x.coords, opt => opt.MapFrom(src => src._pereval.coords))
				.ForMember(x => x.type, opt => opt.MapFrom(src => src._pereval.type))
				.ForMember(x => x.level, opt => opt.MapFrom(src => src._pereval.level))
				.ForMember(x => x.images, opt => opt.MapFrom(src => src._images))
				.ForMember(x => x.add_time, opt => opt.MapFrom(src => src.DateAdded))
				;
		}
	}
}
