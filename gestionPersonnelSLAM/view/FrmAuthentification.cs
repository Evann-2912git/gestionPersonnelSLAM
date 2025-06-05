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

namespace gestionPersonnelSLAM.view
{
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPwd.Text!="")
            {
                Responsable user = new Responsable(txtLogin.Text, txtPwd.Text);
                if (controller.ControleAuthentification(user))
                {
                    FrmGestion frm = new FrmGestion();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Le login ou le mot de passe est incorrect", "Alerte");
                }
            }
            else
            {
                MessageBox.Show("Le login et le mot de passe doivent être saisis", "Information");
            }
        }
    }
}
