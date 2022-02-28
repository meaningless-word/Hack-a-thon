using AutoMapper;
using DTO;
using Repositories.Abstract;
using Services.Abstract;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Services
{
	public class PerevalSerice : IPerevalService
	{
		private IUnitOfWork _unitOfWork;
		private IMapper _mapper;
		public PerevalSerice(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public int AddPereval(PerevalDTO item)
		{
			// проверить на всякое

			// заджейсонить
			string raw_data = JsonSerializer.Serialize<PerevalDTO>(item);


			throw new NotImplementedException();
		}

		public PerevalDTO GetPerevalById(int id)
		{
			var item = _unitOfWork.Perevals.GetItemById(id);
			PerevalDTO itemDTO = JsonSerializer.Deserialize<PerevalDTO>(
				item.RawData, 
				new JsonSerializerOptions() { NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString}
				);

			itemDTO.images = JsonSerializer.Deserialize<ImageDTO>(
				item.Images,
				new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }
				);

			return new PerevalDTO();
		}
	}
}
