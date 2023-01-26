using CarRental.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _user;
        private IUserRepository _userRepository;
        private AppDbContext _appDbContext;

        public UserController(UserManager<AppUser> user, IUserRepository userRepository, AppDbContext appDbContext)
        {
            _user = user;
            _userRepository = userRepository;
            _appDbContext = appDbContext;
        }


        public IActionResult Index(string Name)
        {         
            var user = _user.FindByNameAsync(Name);
            return View(user.Result);
        }
        [HttpPost]
        public IActionResult Edit(AppUser user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.Edit(user);
                return RedirectToAction("Index","Home");
            }
            else
                return View("Index",user);
        }

    }
}
