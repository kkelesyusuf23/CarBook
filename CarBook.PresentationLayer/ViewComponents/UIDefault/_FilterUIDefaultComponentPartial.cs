using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarBook.PresentationLayer.ViewComponents.UIDefault
{
    public class _FilterUIDefaultComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;
            
        public _FilterUIDefaultComponentPartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var brands = _carService.TGetAllCarWithBrands();
            var brandItems = brands.Select(Brand => new SelectListItem { Value = Brand.Brand.BrandName, Text = Brand.Brand.BrandName }).ToList();
            brandItems.Insert(0, new SelectListItem { Value = "", Text = "Marka" });
            ViewData["Brands"] = brandItems;

            var models = _carService.TGetAllCarWithBrands();
            var modelItems = models.Select(Car => new SelectListItem { Value = Car.Model, Text = Car.Model }).ToList();
            modelItems.Insert(0, new SelectListItem { Value = "", Text = "Model" });
            ViewData["Models"] = modelItems;

            return View();
        }
    }
}
