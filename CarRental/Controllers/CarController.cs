using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository carRepository;
        private IPriceListRepository priceListRepository;
        private IReviewRepository reviewRepository;
        

        public CarController(ICarRepository carRepository, IPriceListRepository priceListRepository, IReviewRepository reviewRepository)
        {
            this.carRepository = carRepository;
            this.priceListRepository = priceListRepository;
            this.reviewRepository = reviewRepository;
        }
        [AllowAnonymous]

        public IActionResult Index()
        {
            var viewModel = new PriceListViewModel
            {
                PriceList = priceListRepository.priceLists,
                Cars = carRepository.cars.Where(a => a.IsBroken==false),
                Reviews = reviewRepository.Reviews
            };

            return View(viewModel);
        }
        [Authorize(Roles = "mechanik, admin")]
        public IActionResult BrokenCars()
        {
            var viewModel = new PriceListViewModel
            {
                PriceList = priceListRepository.priceLists,
                Cars = carRepository.cars.Where(a => a.IsBroken == true)
            };
            return View("Index",viewModel);
        }
        [AllowAnonymous]

        public IActionResult CustomersReviews(int carID)
        {
            reviewRepository.Reviews
                .FirstOrDefault(r => r.CarId == carID).Car=carRepository.cars
                .FirstOrDefault(c=>c.Id==carID);
            return View(reviewRepository.Reviews.Where(r=>r.CarId==carID));
        }
    }
}
