using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.model
{
    public class Absence
    {
        public Personnel PersonnelAbsence { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif MotifAbsence { get; set; }

        public Absence(Personnel personnel,DateTime datedebut,DateTime datefin,Motif motif)
        {
            this.PersonnelAbsence = personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.MotifAbsence = motif;
        }
    }
}
