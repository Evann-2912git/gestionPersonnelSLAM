using gestionPersonnelSLAM.controller;
using gestionPersonnelSLAM.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionPersonnelSLAM
{
    public partial class FrmAbsence : Form
    {
        private FrmAbsenceController controller;
        private BindingSource bdgAbsence = new BindingSource();
        private Boolean enCoursDeModif = false;
        private Personnel personnelChoisi;
        public FrmAbsence(Personnel personnelChoisi)
        {
            InitializeComponent();
            this.personnelChoisi = personnelChoisi;
            Init();
        }

        private void Init()
        {
            controller = new FrmAbsenceController();
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RemplirListeAbsence();
            RemplirListeMotif();
        }

        private void btnAffichePersonnel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmGestion frm = new FrmGestion();
            frm.ShowDialog();
        }

        private void RemplirListeAbsence()
        {
            bdgAbsence.DataSource = controller.GetAbsence(personnelChoisi);
            dgvAbsence.DataSource = bdgAbsence;
        }

        private void RemplirListeMotif()
        {
            foreach(Motif motif in controller.GetMotif())
            {
                cboMotif.Items.Add(motif);
            }
            cboMotif.SelectedItem = cboMotif.Items[0];
        }

        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            grpAbsence.Visible = true;
            grpGestionAbsence.Enabled = false;
        }

        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count == 1)
            {
                enCoursDeModif = true;
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDebut.Value = absence.Datedebut;
                dtpFin.Value = absence.Datefin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.MotifAbsence.Libelle);
                grpAbsence.Visible = true;
                grpGestionAbsence.Enabled = false;
            }
            else
            {
                MessageBox.Show("Une ligne doit-être selectionnée", "Information");
            }
        }

        private void btnSupprimmerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count == 1)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer l'absence allant du " + absence.Datedebut + "au " + absence.Datefin + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.SupprimmeAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit-être selectionnée", "Information");
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (dtpDebut.Value<dtpFin.Value)
            {
                Motif motif = (Motif)cboMotif.SelectedItem;
                if (enCoursDeModif)
                {
                    Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                    absence.Datedebut = dtpDebut.Value;
                    absence.Datefin = dtpFin.Value;
                    absence.MotifAbsence = motif;
                    controller.ModifierAbsence(absence);
                }
                else
                {
                    Absence absence = new Absence(personnelChoisi, dtpDebut.Value,dtpFin.Value,motif);
                    controller.AjoutAbsence(absence);
                }
                VideSaisie();
                RemplirListeAbsence();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent-être remplis", "Information");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment annuler", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VideSaisie();
            }
        }

        private void VideSaisie()
        {
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            grpGestionAbsence.Enabled = true;
            grpAbsence.Visible = false;
            enCoursDeModif = false;
        }
    }
}
