using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using gestionPersonnelSLAM.model;


namespace gestionPersonnelSLAM.dal
{
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }
        public List<Personnel> GetPersonnel()
        {
            List<Personnel> lstPersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select personnel.idpersonnel AS idpersonnel, personnel.nom AS nom, personnel.prenom AS prenom, personnel.tel AS tel, personnel.mail AS mail,service.idservice AS idservice, service.nom AS nom ";
                req += "from personnel join service on(personnel.idservice=service.idservice);";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    foreach (Object[] lstObjet in records)
                    {
                        int idpersonnel = (int)lstObjet[0];
                        string nom = (string)lstObjet[1];
                        string prenom = (string)lstObjet[2];
                        string tel = (string)lstObjet[3];
                        string mail = (string)lstObjet[4];
                        Service service = new Service((int)lstObjet[5], (string)lstObjet[6]);
                        Personnel personnel = new Personnel(idpersonnel, nom, prenom, tel, mail, service);
                        lstPersonnel.Add(personnel);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lstPersonnel;
        }

        public void AjoutPersonnel(Personnel personnel)
        {
            if (access.Manager != null) 
            {
                string req = "INSERT INTO personnel ";
                req += "VALUES (0,@nom,@prenom,@tel,@mail,@idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.ServicePersonnel.Idservice);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        public void SupprimmePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM personnel WHERE idpersonnel=@idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void ModifierPersonnel(Personnel personnel)
        {
            if (access.Manager!=null)
            {
                string req = "UPDATE personnel SET nom=@nom,prenom=@prenom,tel=@tel,mail=@mail,idservice=@idservice ";
                req += "WHERE idpersonnel=@idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel",personnel.Idpersonnel);
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@Mail", personnel.Mail);
                parameters.Add("@idservice", personnel.ServicePersonnel.Idservice);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
