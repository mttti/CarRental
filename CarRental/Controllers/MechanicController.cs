using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Authorize(Roles = "mechanik, admin")]
    public class MechanicController : Controller
    {
        public readonly IPriceListRepository priceListRepository;
        public readonly ICarRepository carRepository;
        public readonly ICarDefectRepository carDefectRepository;

        public MechanicController(IPriceListRepository priceListRepository, ICarRepository carRepository, ICarDefectRepository carDefectRepository)
        {
            this.priceListRepository = priceListRepository;
            this.carRepository = carRepository;
            this.carDefectRepository = carDefectRepository;
        }     
        public IActionResult BrokenCars()
        {
            var viewModel = new BrokenCarsViewModel
            {
                CarDefects = carDefectRepository.carDefects.Where(s=>s.IsSolved==false || s.IsSolved is null),
                Cars = carRepository.cars
            };          
            return View(viewModel);
        }

        public IActionResult Repair(int carID, int reportID)
        {
            var report = carDefectRepository.carDefects.FirstOrDefault(i=>i.Id==reportID);
            report.IsSolved=true;
            carDefectRepository.Save(report);

            if (carDefectRepository.carDefects.Where(i => i.CarId == carID).All(s => s.IsSolved == true))
            {
                var car = carRepository.cars.FirstOrDefault(i=>i.Id== carID);
                car.IsBroken = false;
                carRepository.Save(car);
            }

            return RedirectToAction("BrokenCars");
        }


        public IActionResult History(int carID)
        {
            var viewModel = new BrokenCarsViewModel
            {
                CarDefects = carDefectRepository.carDefects.Where(s => s.IsSolved == true && s.CarId==carID),
                Cars = carRepository.cars
            };
            return View(viewModel);
        }
    }
}
