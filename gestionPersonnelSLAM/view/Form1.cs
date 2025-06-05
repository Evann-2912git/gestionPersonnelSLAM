using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionPersonnelSLAM.controller;
using gestionPersonnelSLAM.model;

namespace gestionPersonnelSLAM
{
    public partial class FrmGestion : Form
    {
        private FrmGestionController controller;
        private BindingSource bdgPersonnel = new BindingSource();
        private Boolean enCoursDeModif = false;
        public FrmGestion()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmGestionController();
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RemplirListePersonnel();
            RemplirListeService();
        }

        private void RemplirListePersonnel()
        {
            bdgPersonnel.DataSource = controller.GetPersonnel();
            dgvPersonnel.DataSource = bdgPersonnel;
        }

        private void RemplirListeService()
        {
            foreach(Service service in controller.GetServices())
            {
                cboService.Items.Add(service);
            }
            cboService.SelectedItem = cboService.Items[0];
        }

        private void btnAfficheAbsence_Click(object sender, EventArgs e)
        {

            if (dgvPersonnel.SelectedRows.Count == 1)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                FrmAbsence frm = new FrmAbsence(personnel);
                frm.ShowDialog();
            }
        }

        private void btnAjoutPersonnel_Click(object sender, EventArgs e)
        {
            grpPersonnel.Visible = true;
            grpGestion.Enabled = false;
        }

        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 1)
            {
                enCoursDeModif = true;
                Personnel personnel= (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.ServicePersonnel.Nom);
                grpPersonnel.Visible = true;
                grpGestion.Enabled = false;
            }
            else
            {
                MessageBox.Show("Une ligne doit-être selectionnée", "Information");
            }
        }

        private void btnSupprimmerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count==1)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if(MessageBox.Show("Voulez vous vraiment supprimer "+personnel.Nom+" "+personnel.Prenom+" ?","Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.SupprimmePersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit-être selectionnée", "Information");
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtTel.Text != "" && txtMail.Text != "")
            {
                Service service = (Service)cboService.SelectedItem;
                if (enCoursDeModif)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.ServicePersonnel = service;
                    controller.ModifierPersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AjoutPersonnel(personnel);
                }
                VideSaisie();
                RemplirListePersonnel();
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
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            grpGestion.Enabled = true;
            grpPersonnel.Visible = false;
            enCoursDeModif = false;
        }
    }
}
