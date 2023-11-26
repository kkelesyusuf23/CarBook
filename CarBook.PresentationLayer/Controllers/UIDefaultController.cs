using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class UIDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
