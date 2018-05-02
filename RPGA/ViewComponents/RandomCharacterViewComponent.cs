using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RPGA.Common;
using RPGA.Logic.Models.Interfaces;
using RPGA.Logic.Interfaces;
using RPGA.Presentation.Models;
using System.Threading.Tasks;

namespace RPGA.Presentation.ViewComponents
{
	public class RandomCharacterViewComponent : ViewComponent
	{
		protected ICharacterService CharacterService { get; set; }
		protected IMapper _mapper { get; set; }

		public RandomCharacterViewComponent(ICharacterService characterService, IMapper mapper)
		{
			CharacterService = characterService;
			_mapper = mapper;
		}

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public async Task<IViewComponentResult> InvokeAsync(Constants.Races RaceConstraint)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
		{
			var viewModel = _mapper.Map<ICharacter, CharacterVM>(CharacterService.CreateRandomCharacter(RaceConstraint));

			return View("~/Views/Character/Components/_Overview.cshtml", viewModel);
		}
	}
}