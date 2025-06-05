using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.model
{
    public class Responsable
    {
        public string Login { get; set; }
        public string Pwd { get; set; }
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
