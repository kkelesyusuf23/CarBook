using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class BrandController1cs : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController1cs(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var values = _brandService.TGetListAll();
            return View(values);
        }
    }
}
