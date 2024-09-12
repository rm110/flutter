using VigilanceFire.Data;
using VigilanceFire.Models;

namespace VigilanceFire.Repository
{
    public interface IGasControllerRepository
    {
        GasController GetGasController();
    }
    public class GasControllerRepository : IGasControllerRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public GasController GetGasController()
        {
            var gasController = new GasController 
            { 

            };
            return gasController;
        }
    }
}
