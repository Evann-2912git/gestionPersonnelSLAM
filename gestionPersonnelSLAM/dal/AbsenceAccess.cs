using gestionPersonnelSLAM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnelSLAM.dal
{
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Absence> GetAbsence(Personnel personnelChoisi)
        {
            List<Absence> lstAbsence = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select personnel.idpersonnel AS idpersonnel, personnel.nom AS nom, personnel.prenom AS prenom, personnel.tel AS tel, personnel.mail AS mail,absence.idpersonnel AS idpersonnel, personnel.nom AS nom,absence.datedebut AS datedebut,absence.datefin AS datefin,motif.idmotif AS idmotif, motif.libelle AS libelle,service.idservice AS idservice, service.nom AS nom ";
                req += "from absence join motif on(absence.idmotif=motif.idmotif) ";
                req += "join personnel on (absence.idpersonnel=personnel.idpersonnel) ";
                req += "join service on(personnel.idservice=service.idservice) ";
                req += "where personnel.idpersonnel=@idpersonnel; ";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnelChoisi.Idpersonnel);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req,parameters);
                    foreach (Object[] lstObjet in records)
                    {
                        Personnel personnel = new Personnel((int)lstObjet[0], (string)lstObjet[1], (string)lstObjet[2], (string)lstObjet[3], (string)lstObjet[4],new Service((int)lstObjet[5], (string)lstObjet[6]));
                        DateTime datedebut = (DateTime)lstObjet[7];
                        DateTime datefin = (DateTime)lstObjet[8];
                        Motif motif = new Motif((int)lstObjet[9], (string)lstObjet[10]);
                        Absence absence = new Absence(personnel, datedebut, datefin, motif);
                        lstAbsence.Add(absence);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lstAbsence;
        }

        public void AjoutAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO absence ";
                req += "VALUES (0,@datedebut,@datefin,@idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.MotifAbsence.Idmotif);
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
        public void SupprimmeAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE idabsence=@idabsence ";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.PersonnelAbsence.Idpersonnel);
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

        public void ModifierAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "UPDATE absence SET datedebut=@datedebut,datefin=@datefin,idmotif=@idmotif ";
                req += "WHERE idpersonnel=@idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.PersonnelAbsence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.MotifAbsence.Idmotif);
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

    }
}
