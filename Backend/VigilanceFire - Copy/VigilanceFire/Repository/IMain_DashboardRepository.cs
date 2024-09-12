using VigilanceFire.Data;
using VigilanceFire.Models;

namespace VigilanceFire.Repository
{
    public interface IMain_DashboardRepository
    {
        Main_Dashboard GetDashboardData();
    }

    public class DashboardRepository : IMain_DashboardRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public Main_Dashboard GetDashboardData()
        {
            var dasboard = new Main_Dashboard
            {

            };

            return dasboard;
        }
    }
}
