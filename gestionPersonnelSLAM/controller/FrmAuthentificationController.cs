using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionPersonnelSLAM.dal;
using gestionPersonnelSLAM.model;

namespace gestionPersonnelSLAM.controller
{
    public class FrmAuthentificationController
    {
        private readonly ResponsableAccess responsableAccess;
        public FrmAuthentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }
        public bool ControleAuthentification(Responsable user)
        {
            return responsableAccess.ControleAuthentification(user);
        }
    }
}
