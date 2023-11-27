using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class UICarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
