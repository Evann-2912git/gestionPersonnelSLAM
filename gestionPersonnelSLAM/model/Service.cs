﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.model
{
    public class Service
    {
        public int Idservice { get; set; }
        public string Nom { get; set; }
        public Service(int idservice,string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
