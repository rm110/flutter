using Microsoft.AspNetCore.Mvc;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class GasControllerController : Controller
    {
        IGasControllerRepository gasRepo;
        public GasControllerController(IGasControllerRepository _gasRepo)
        {
            gasRepo = _gasRepo;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
