using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository carRepository;
        private IPriceListRepository priceListRepository;
        

        public CarController(ICarRepository carRepository, IPriceListRepository priceListRepository)
        {
            this.carRepository = carRepository;
            this.priceListRepository = priceListRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new PriceListViewModel
            {
                PriceList = priceListRepository.priceLists,
                Cars = carRepository.cars.Where(a => a.IsBroken==false)
            };

            return View(viewModel);
        }

        public IActionResult BrokenCars()
        {
            var viewModel = new PriceListViewModel
            {
                PriceList = priceListRepository.priceLists,
                Cars = carRepository.cars.Where(a => a.IsBroken == true)
            };

            return View("Index",viewModel);
        }
    }
}
