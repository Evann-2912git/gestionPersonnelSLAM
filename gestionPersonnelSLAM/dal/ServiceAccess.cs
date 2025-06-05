using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionPersonnelSLAM.model;

namespace gestionPersonnelSLAM.dal
{
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }
        public List<Service>GetServices()
        {
            string req = "SELECT* FROM service";
            List<Service> lstService = new List<Service>();
            try
            {
                List<Object[]> records = access.Manager.ReqSelect(req);
                foreach (Object[] lstObjet in records)
                {
                    Service service = new Service((int)lstObjet[0],(string)lstObjet[1]);
                    lstService.Add(service);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            return lstService;

        }

    }
}
