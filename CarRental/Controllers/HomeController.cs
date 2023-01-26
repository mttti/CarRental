using CarRental.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Diagnostics;

namespace CarRental.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private IPriceListRepository _priceListRepository;

        public HomeController(IPriceListRepository priceListRepository)
        {
            _priceListRepository = priceListRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult PriceList()
        {
            return View(_priceListRepository.priceLists);
        }
    }
}