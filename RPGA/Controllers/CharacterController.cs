using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RPGA.Common;
using RPGA.Logic.Interfaces;
using RPGA.Logic.Models.Interfaces;
using RPGA.Presentation.Models;

namespace RPGA.Presentation.Controllers
{
	public class CharacterController : BaseController
	{
		protected ICharacterService CharacterService { get; set; }

		public CharacterController(ICharacterService characterService, IMapper mapper) : base(mapper)
		{
			CharacterService = characterService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetRandomCharacter(Constants.Races RaceConstraint)
		{
			return ViewComponent("RandomCharacter", RaceConstraint);
		}

		public IActionResult LoadLast()
		{
			var viewModel = Mapper.Map<ICharacter, CharacterVM>(CharacterService.LoadLast());
			return View("~/Views/Character/Components/_Overview.cshtml", viewModel);
		}

		//public IActionResult Random()
		//{
		//	var viewModel = _mapper.Map<ICharacter, CharacterVM>(CharacterService.CreateRandomCharacter());

		//	return PartialView(viewModel);
		//}
	}
}