using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        public readonly IReviewRepository reviewRepository;
        public readonly ICarRepository carRepository;
        public readonly IPriceListRepository priceListRepository;
        public readonly IOrderRepository orderRepository;
        public readonly ICarDefectRepository carDefectRepository;
        public readonly IRoleRepository roleRepository;
        public readonly IUserRepository userRepository;
        public readonly UserManager<AppUser> userManager;


        public AdminController(IUserRepository userRepository, IReviewRepository reviewRepository, ICarRepository carRepository, IPriceListRepository priceListRepository, IOrderRepository orderRepository, ICarDefectRepository carDefectRepository, IRoleRepository roleRepository, UserManager<AppUser> userManager)
        {
            this.userRepository = userRepository;
            this.reviewRepository = reviewRepository;
            this.carRepository = carRepository;
            this.priceListRepository = priceListRepository;
            this.orderRepository = orderRepository;
            this.carDefectRepository = carDefectRepository;
            this.roleRepository = roleRepository;
            this.userManager = userManager;
        }
        public IActionResult Reviews()
        {
            return View(reviewRepository.Reviews);
        }

        public IActionResult ReviewDelete(int reviewID)
        {
            //var review = reviewRepository.Reviews.FirstOrDefault(i=>i.Id==reviewID);
            reviewRepository.Delete(reviewID);
            return RedirectToAction("Reviews");
        }

        [HttpGet]
        public IActionResult ReviewEdit(int reviewID = 0)
        {
            var viewModel = new ReviewEditViewModel()
            {
                Review = reviewRepository.Reviews.FirstOrDefault(i => i.Id == reviewID) ?? new Review(),
                selectListItem = carRepository.cars.Select(x => new SelectListItem()
                {
                    Text = x.Id.ToString(),
                    Value = x.Id.ToString()
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ReviewEdit(ReviewEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                reviewRepository.Save(viewModel.Review);
                return RedirectToAction("Reviews");
            }
            else
                return View(viewModel);
        }

        public IActionResult PriceList()
        {
            var viewModel = new PriceListViewModel
            {
                PriceList = priceListRepository.priceLists,
                Cars = carRepository.cars,
            };
            return View(viewModel);
        }

        [HttpGet]
        public ViewResult PriceListEdit(int priceListID = 0)
        {
            return View(priceListRepository.priceLists.FirstOrDefault(o => o.PriceListId == priceListID) ?? new PriceList());
        }
        [HttpPost]
        public IActionResult PriceListEdit(PriceList priceList)
        {
            if (ModelState.IsValid)
            {
                priceListRepository.Save(priceList);
                //TempData["message"] = $"{priceList.CarType} został edytowany.";
                return RedirectToAction("PriceList");
            }
            else
                return View(priceList);
        }

        public IActionResult PriceListDelete(int priceListID)
        {
            priceListRepository.Delete(priceListID);
            return RedirectToAction("PriceList");
        }

        public IActionResult Orders()
        {
            var viewModel = new OrderListViewModel
            {
                Cars = carRepository.cars,
                Orders = orderRepository.Orders
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult OrderEdit(int orderID = 0)
        {
            var viewModel = new OrderEditViewModel
            {
                Order = orderRepository.Orders.FirstOrDefault(i => i.Id == orderID) ?? new Order(),
                carIds = carRepository.cars.Select(x => new SelectListItem()
                {
                    Text = x.Id.ToString(),
                    Value = x.Id.ToString()
                }).ToList(),
                userNames = userManager.Users.Select(x => new SelectListItem()
                {
                    Text = x.UserName.ToString(),
                    Value = x.Id
                }).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult OrderEdit(OrderEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                orderRepository.Save(viewModel.Order);
                return RedirectToAction("Orders");
            }
            return View(viewModel);
        }

        public IActionResult OrderDelete(int orderID)
        {
            orderRepository.Delete(orderID);
            return RedirectToAction("Orders");
        }

        public IActionResult Cars()
        {
            var viewModel = new PriceListViewModel
            {
                Cars = carRepository.cars,
                PriceList = priceListRepository.priceLists,
                Reviews = reviewRepository.Reviews
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult CarEdit(int carID = 0)
        {
            var viewModel = new CarEditViewModel
            {
                Car = carRepository.cars.FirstOrDefault(i => i.Id == carID) ?? new Car(),
                CarTypes = priceListRepository.priceLists.Select(x => new SelectListItem()
                {
                    Text = x.CarType.ToString(),
                    Value = x.PriceListId.ToString(),
                }).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CarEdit(CarEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                carRepository.Save(viewModel.Car);
                return RedirectToAction("Cars");
            }
            return View(viewModel);
        }

        public IActionResult CarDelete(int carID)
        {
            carRepository.Delete(carID);
            return RedirectToAction("Cars");
        }

        public IActionResult CarDefects()
        {
            var viewModel = new BrokenCarsViewModel
            {
                CarDefects = carDefectRepository.carDefects,
                Cars = carRepository.cars
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult CarDefectEdit(int reportID = 0)
        {
            var viewModel = new CarDefectEditViewModel
            {
                carDefect = carDefectRepository.carDefects.FirstOrDefault(i=>i.Id==reportID) ?? new CarDefect(),
                CarIDs = carRepository.cars.Select(x => new SelectListItem()
                {
                    Text = $"{x.Brand} {x.Model}",
                    Value = x.Id.ToString()
                }).ToList(),
                OrderIDs = orderRepository.Orders.Select(x => new SelectListItem()
                {
                    Text = x.Id.ToString(),
                    Value = x.Id.ToString()
                }).ToList(),
                UserNames = userManager.Users.Select(x => new SelectListItem()
                {
                    Text = x.UserName.ToString(),
                    Value = x.UserName
                }).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CarDefectEdit(CarDefectEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                carDefectRepository.Save(viewModel.carDefect);
                return RedirectToAction("CarDefects");
            }
            return View(viewModel);
        }

        public IActionResult CarDefectDelete(int reportID)
        {
            carDefectRepository.Delete(reportID);
            return RedirectToAction("CarDefects");
        }

        public IActionResult Roles()
        {      
            return View(roleRepository.roles);
        }

        [HttpGet]
        public IActionResult RoleEdit(string roleID = null)
        {
            return View(roleRepository.roles.FirstOrDefault(i=>i.Id== roleID) ?? new IdentityRole());
        }

        [HttpPost]
        public IActionResult RoleEdit(IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                roleRepository.Edit(role);
                return RedirectToAction("Roles");
            }
            return View(role);
        }

        public IActionResult RoleDelete(string roleID)
        {
            roleRepository.Delete(roleID);
            return RedirectToAction("Roles");
        }

        public IActionResult Users()
        {
            return View(userRepository.users);
        }

        [HttpGet]
        public IActionResult UserEdit(string userID = null)
        {
            var viewModel = new UserEditViewModel
            {
                User = userRepository.users.FirstOrDefault(i => i.Id == userID) ?? new AppUser(),
                Roles = roleRepository.roles.Select(x => new SelectListItem()
                {
                    Text = $"{x.Name}",
                    Value = x.Name
                }).ToList(),
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserEditViewModel viewModel)
        {         
            if (ModelState.IsValid)
            {
                userRepository.Edit(viewModel.User);
                return RedirectToAction("Users");
            }
            return View(viewModel);
        }

        public IActionResult UserDelete(string userID)
        {
            userRepository.Delete(userID);
            return RedirectToAction("Users");
        }

        [HttpGet]
        public async Task<IActionResult> UserRegister()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(RegisterViewModel registerViewModel)
        {           
            if (ModelState.IsValid)
            {
                var user = new AppUser() { UserName = registerViewModel.Login, Email = registerViewModel.Email, Name = registerViewModel.Name, LastName = registerViewModel.LastName };
                var result = await userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {                 
                    userManager.AddToRoleAsync(user, "uzytkownik");                    
                    return RedirectToAction("Users");
                }
                ModelState.AddModelError("Login", "Ten login jest już zajęty");
            }
            return View(registerViewModel);
        }
    }
}

