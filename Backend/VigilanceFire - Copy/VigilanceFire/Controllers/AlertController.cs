using Microsoft.AspNetCore.Mvc;
using VigilanceFire.Models;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class AlertController : Controller
    {
        IAlertRepository alertRepo;

        public AlertController(IAlertRepository _alertRepo)
        {
            alertRepo = _alertRepo;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Alert alert)
        {
            if (ModelState.IsValid)
            {
                alertRepo.AddAlert(alert);
                return RedirectToAction("Index");
            }
            return View(alert);
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

        public IActionResult Resolve(int id)
        {
            alertRepo.ResolveAlert(id);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
