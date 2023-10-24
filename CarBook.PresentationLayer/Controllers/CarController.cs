using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetListAll();
            return View(values);
        }
		public IActionResult Index2()
		{
			var values = _carService.TGetAllCarWithBrands();//bu method brand carCategori ve carStatus tablolarını da dahil ediyor
			return View(values);
		}
	}
}
