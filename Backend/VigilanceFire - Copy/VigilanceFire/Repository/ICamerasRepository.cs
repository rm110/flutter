using VigilanceFire.Data;
using VigilanceFire.Models;

namespace VigilanceFire.Repository
{
    public interface ICamerasRepository
    {
        List<Cameras> GetAllCameras();
        public Cameras GetCameraById(int id);
        public void ActivateCamera(int id);
        public void DeactivateCamera(int id);
    }

    public class CamerasRepository : ICamerasRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public void ActivateCamera(int id)
        {
            
        }

        public void DeactivateCamera(int id)
        {
            
        }

        public List<Cameras> GetAllCameras()
        {
            return db.CameraControls.ToList();
        }

        public Cameras GetCameraById(int id)
        {
            return db.CameraControls.SingleOrDefault(c => c.Cam_Id == id);
        }
    }
}
