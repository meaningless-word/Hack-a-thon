using AutoMapper;
using DTO;
using Models;

namespace Mappers
{
	public class UserMapper : Profile
	{
		public UserMapper()
		{
			CreateMap<UserModel, UserDTO>();
			CreateMap<UserDTO, UserModel>();
		}
	}
}
