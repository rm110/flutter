using Microsoft.AspNetCore.Mvc;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class Main_DashboardController : Controller
    {
        IMain_DashboardRepository dashboardRepo;
        public Main_DashboardController(IMain_DashboardRepository _dashboardRepo)
        {
            dashboardRepo = _dashboardRepo;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
