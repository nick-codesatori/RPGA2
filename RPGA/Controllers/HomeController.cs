using Microsoft.AspNetCore.Mvc;
using RPGA.Presentation.Models;
using System.Diagnostics;

namespace RPGA.Presentation.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return RedirectToAction("Index", "Character");
		}

		public IActionResult Error()
		{
			return View(new ErrorVM { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
