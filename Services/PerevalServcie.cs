using AutoMapper;
using DTO;
using Repositories.Abstract;
using Services.Abstract;
using System;

using System.Text.Json;

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
	}
}
