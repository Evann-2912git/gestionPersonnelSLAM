using gestionPersonnelSLAM.dal;
using gestionPersonnelSLAM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.controller
{
    public class FrmAbsenceController
    {
        private readonly AbsenceAccess absenceAccess;
        private readonly MotifAccess motifAccess;

        public FrmAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        public List<Absence> GetAbsence(Personnel personnelChoisi)
        {
            return absenceAccess.GetAbsence(personnelChoisi);
        }

        public List<Motif> GetMotif()
        {
            return motifAccess.GetMotif();
        }

        public void AjoutAbsence(Absence absence)
        {
            absenceAccess.AjoutAbsence(absence);
        }

        public void SupprimmeAbsence(Absence absence)
        {
            absenceAccess.SupprimmeAbsence(absence);
        }

        public void ModifierAbsence(Absence absence)
        {
            absenceAccess.ModifierAbsence(absence);
        }
    }
}
