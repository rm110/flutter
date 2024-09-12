using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class CamerasController : Controller
    {
        ICamerasRepository cameraRepo;
        public CamerasController(ICamerasRepository _cameraRepo)
        {
            cameraRepo = _cameraRepo;
        }
        public IActionResult Activate(int id)
        {
            cameraRepo.ActivateCamera(id);
            return RedirectToAction("Index");
        }
        public IActionResult Deactivate(int id)
        {
            cameraRepo.DeactivateCamera(id);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
