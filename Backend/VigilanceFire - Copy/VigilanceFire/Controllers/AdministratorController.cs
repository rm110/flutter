using Microsoft.AspNetCore.Mvc;
using VigilanceFire.Models;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class AdministratorController : Controller
    {
        IAdministratorRepository adminRepo;

        public AdministratorController(IAdministratorRepository _adminRepo)
        {
            adminRepo = _adminRepo;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(int admin_Id, string name)
        {
            var admin = adminRepo.SignIn(admin_Id, name);
            if (admin == null)
            {
                return BadRequest();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                adminRepo.AddUser(user);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {

            return View();
        }

        public IActionResult Delete(int id)
        {

            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            return RedirectToAction("Index");
        }

        public IActionResult Update(int? Id)
        {

            return View();
        }

        [HttpPost]
        public IActionResult Update(User user)
        {

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var res = adminRepo.GetAll();
            return View(res);
        }
    }
}
