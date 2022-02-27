using AutoMapper;
using DTO;
using Models;

namespace Mappers
{
	public class ImageMapper : Profile
	{
		public ImageMapper()
		{
			CreateMap<ImageModel, ImageDTO>();
		}
	}
}
