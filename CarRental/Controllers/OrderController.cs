using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICarRepository carRepository;
        private readonly IPriceListRepository priceListRepository;
        private readonly ICarDefectRepository carDefectRepository;
        private readonly IReviewRepository reviewRepository;
        private readonly IOrderRepository orderRepository;
        private readonly UserManager<AppUser> _user;


        public OrderController(ICarRepository carRepository, IPriceListRepository priceListRepository, IOrderRepository orderRepository, UserManager<AppUser> user,
            IReviewRepository reviewRepository, ICarDefectRepository carDefectRepository)
        {
            this.carRepository = carRepository;
            this.priceListRepository = priceListRepository;
            this.orderRepository = orderRepository;
            _user = user;
            this.reviewRepository = reviewRepository;
            this.carDefectRepository = carDefectRepository;
        }
        [HttpGet]
        public IActionResult Add(int CarID, string userName)
        {
            var viewModel = new OrderViewModel
            {
                Car = carRepository.cars.FirstOrDefault(i=>i.Id==CarID),
                Order = new Order { CarId = CarID, UserId = _user.FindByNameAsync(userName).Result.Id}
            };
            viewModel.PriceList = priceListRepository.priceLists.FirstOrDefault(i => i.PriceListId == viewModel.Car.PriceListId);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(OrderViewModel orderViewModel)      
        {
            orderViewModel.Car = carRepository.cars.FirstOrDefault(i => i.Id == orderViewModel.Order.CarId);
            orderViewModel.PriceList = priceListRepository.priceLists.FirstOrDefault(i => i.PriceListId == orderViewModel.Car.PriceListId);
            if (ModelState.IsValid)
                {

                decimal dayDiff= (decimal)(orderViewModel.Order.EndDate- orderViewModel.Order.StartDate).TotalDays;
                orderViewModel.Order.Price = orderViewModel.PriceList.BasePrice + orderViewModel.PriceList.Price * dayDiff;

                orderRepository.Save(orderViewModel.Order);
                return RedirectToAction("Index", "Car");
            }
            else
            {
                return View(orderViewModel);
            }
        }
        
        public IActionResult Index(string userName)
        {
            var userID = _user.FindByNameAsync(userName).Result.Id;
            var viewModel = new OrderListViewModel
            {
                Cars = carRepository.cars,
                Orders = orderRepository.Orders.Where(u => u.UserId == userID).ToList()
            };

            foreach(var order in viewModel.Orders)
            {
                foreach (var review in reviewRepository.Reviews)
                {
                    if(review.OrderId == order.Id)
                    {
                        order.IsReviewed = true;
                        orderRepository.Save(order);
                    }
                }
                foreach(var report in carDefectRepository.carDefects)
                {
                    if(report.OrderId == order.Id)
                    {
                        order.IsReported = true;
                        orderRepository.Save(order);
                    }
                }
            }
       
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddReview(int carID, int orderID)
        {
            var review = new Review { CarId = carID, OrderId=orderID };
            return View(review);
        }

        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            if (ModelState.IsValid)
            {
                reviewRepository.Save(review);
                return RedirectToAction("Index" ,new {userName = review.userName});
            }
            else
                return View(review);
        }
        [HttpGet]
        public IActionResult ReportDefect(int carID, int orderID)
        {
            var carDefect = new CarDefect { CarId = carID, OrderId=orderID };
            return View(carDefect);
        }

        [HttpPost]
        public IActionResult ReportDefect(CarDefect carDefect)
        {
            if (ModelState.IsValid)
            {
                carDefectRepository.Save(carDefect);
                var brokenCar = carRepository.cars.FirstOrDefault(i => i.Id == carDefect.CarId);
                brokenCar.IsBroken = true;
                carRepository.Save(brokenCar);
                return RedirectToAction("Index", new { userName = carDefect.UserName });
            }
            else
                return View(carDefect);
        }

    }
}
