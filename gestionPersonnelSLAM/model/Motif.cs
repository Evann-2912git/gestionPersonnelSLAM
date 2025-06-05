using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.model
{
    public class Motif
    {
        public int Idmotif { get; set; }
        public string Libelle { get; set; }
        public Motif(int idmotif,string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
    }
}
