using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.model
{
    public class Personnel
    {
        public int Idpersonnel { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public Service ServicePersonnel { get; set; }
        public Personnel(int idpersonnel,string nom,string prenom,string tel,string mail,Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.ServicePersonnel=service;
        }
    }
}
