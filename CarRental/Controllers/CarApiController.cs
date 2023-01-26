using CarRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarApiController : ControllerBase
    {
        private readonly ICarRepository carRepository;
        private readonly IPriceListRepository priceListRepository;

        public CarApiController(ICarRepository carRepository, IPriceListRepository priceListRepository)
        {
            this.carRepository = carRepository;
            this.priceListRepository = priceListRepository;
        }

        [HttpGet]
        [Route("GetAllCars")]
        public IActionResult GetAllCars()
        {
            var allCars=carRepository.cars.ToList();
            return Ok(allCars);
        }

        [HttpGet]
        [Route("GetOneCar")]
        public IActionResult GetCar(int carID)
        {
            if(carID.GetType() != typeof(int))
            {
                return BadRequest();
            }
            if (!carRepository.cars.Any(i => i.Id == carID))
            {
                return NotFound();
            }
            return Ok(carRepository.cars.FirstOrDefault(i => i.Id == carID));
        }

        [HttpDelete]
        [Route("CarDelete")]
        public IActionResult CarDelete(int carID)
        {
            if (carID.GetType() != typeof(int))
            {
                return BadRequest();
            }
            if (!carRepository.cars.Any(i => i.Id == carID))
            {
                return NotFound();
            }
            carRepository.Delete(carID);
            return Ok();
        }

        [HttpPost]
        [Route("CarAdd")]
        public IActionResult CarAdd([FromBody] Car car)
        {
            car.Id = 0;
            if (!priceListRepository.priceLists.Any(i => i.PriceListId == car.PriceListId))
            {
                return BadRequest();
            }
            carRepository.Save(car);
            return Ok(car);
        }

        [HttpPut]
        [Route("CarPut")]
        public IActionResult CarPut([FromBody] Car car)
        {
            if (car.Id.GetType() != typeof(int))
            {
                return BadRequest();
            }
            if(!priceListRepository.priceLists.Any(i => i.PriceListId == car.PriceListId))
            {
                return BadRequest();
            }
            if (!carRepository.cars.Any(i => i.Id == car.Id))
            {
                return NotFound();
            }
            carRepository.Save(car);
            return Ok(car);
        }
    }
}
