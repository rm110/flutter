using Microsoft.EntityFrameworkCore;
using VigilanceFire.Data;
using VigilanceFire.Models;

namespace VigilanceFire.Repository
{
    public interface IAlertRepository
    {
        public List<Alert> GetAllAlerts();
        public Alert GetAlertById(int id); 
        public void AddAlert(Alert alert); 
        public void DeleteAlert(int id);
        public void ResolveAlert(int id);
    }

    public class AlertRepository : IAlertRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public void AddAlert(Alert alert)
        {
            db.Alerts.Add(alert);
            db.SaveChanges();
        }
      
        public void DeleteAlert(int id)
        {
            var alert = db.Alerts.FirstOrDefault(a => a.alert_Id == id);
            db.Alerts.Remove(alert);
            db.SaveChanges();
        }

        public Alert GetAlertById(int id)
        {
            return db.Alerts.FirstOrDefault(a => a.alert_Id == id);
        }

        public List<Alert> GetAllAlerts()
        {
            
            return db.Alerts.Where(a => a.condition == true).ToList();
        }


        public void ResolveAlert(int id)
        {
            var alert = db.Alerts.FirstOrDefault(a => a.alert_Id == id);
            if (alert != null)
            {
                alert.condition = true;
                db.SaveChanges();
            }
        }
    }
}
