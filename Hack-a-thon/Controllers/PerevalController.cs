using AutoMapper;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Models.Pereval;
using Services.Abstract;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Hack_a_thon.Controllers
{
	/// <summary>
	/// Контроллер ...
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[SwaggerTag("Карточка объекта Перевал")]
	public class PerevalController : ControllerBase
	{
		private IMapper _mapper;
		private IPerevalService _perevalService;
		public PerevalController(IPerevalService perevalService, IMapper mapper)
		{
			_mapper = mapper;
			_perevalService = perevalService;
		}

		/// <summary>
		/// Добавление новой карточки перевала
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("Add")]
		public IActionResult Add([FromBody] AddPerevalRequest request)
		{
			try
			{
				int id = _perevalService.AddPereval(_mapper.Map<AddPerevalRequest, PerevalDTO>(request));
				return StatusCode(200, $"{request.title} Пока всё норм... {id}");

			}
			catch (Exception ex)
			{
				return StatusCode(400, $"Ошибка: нехватка полей! {ex.Message}");
			}

		}

		[HttpGet]
		[Route("GetById/{id}")]
		public IActionResult GetPereval([FromRoute] int id)
		{
			var result = _mapper.Map<PerevalDTO, GetPerevalResponse>(_perevalService.GetPerevalById(id));




			return StatusCode(200, result);
		}
	}
}
