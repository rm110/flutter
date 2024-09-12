using Microsoft.AspNetCore.Mvc;
using System;
using VigilanceFire.Models;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepo;
        public UserController(IUserRepository _userRepo)
        {
            userRepo = _userRepo; 
        }

        // GET
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(int user_Id, string name)
        {
            var user = userRepo.SignIn(user_Id, name);
            if (user == null)
            {
                return BadRequest();
            }

            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var res = userRepo.GetAll();
            return View(res);
        }
    }
}
