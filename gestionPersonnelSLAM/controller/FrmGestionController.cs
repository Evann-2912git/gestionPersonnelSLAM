using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionPersonnelSLAM.dal;
using gestionPersonnelSLAM.model;

namespace gestionPersonnelSLAM.controller
{
    public class FrmGestionController
    {
        private readonly PersonnelAccess personnelAccess;
        private readonly ServiceAccess serviceAccess;
        public FrmGestionController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        public List<Personnel> GetPersonnel()
        {
            return personnelAccess.GetPersonnel();
        }

        public List<Service> GetServices()
        {
            return serviceAccess.GetServices();
        }

        public void AjoutPersonnel(Personnel personnel)
        {
            personnelAccess.AjoutPersonnel(personnel);
        }

        public void SupprimmePersonnel(Personnel personnel)
        {
            personnelAccess.SupprimmePersonnel(personnel);
        }

        public void ModifierPersonnel(Personnel personnel)
        {
            personnelAccess.ModifierPersonnel(personnel);
        }
    }
}
