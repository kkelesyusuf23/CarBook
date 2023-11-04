using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
