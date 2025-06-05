using gestionPersonnelSLAM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.dal
{
    public class MotifAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public MotifAccess()
        {
            access = Access.GetInstance();
        }

        public List<Motif> GetMotif()
        {
            string req = "SELECT* FROM motif";
            List<Motif> lstMotif = new List<Motif>();
            try
            {
                List<Object[]> records = access.Manager.ReqSelect(req);
                foreach (Object[] lstObjet in records)
                {
                    Motif motif = new Motif((int)lstObjet[0], (string)lstObjet[1]);
                    lstMotif.Add(motif);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            return lstMotif;

        }
    }
}
