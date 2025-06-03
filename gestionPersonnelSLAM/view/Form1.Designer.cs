namespace gestionPersonnelSLAM
{
    partial class FrmGestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.dgvGestion = new System.Windows.Forms.DataGridView();
            this.btnAfficheAbsence = new System.Windows.Forms.Button();
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAjoutPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimmerPersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lnlNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.grpGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).BeginInit();
            this.grpPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.btnSupprimmerPersonnel);
            this.grpGestion.Controls.Add(this.btnModifierPersonnel);
            this.grpGestion.Controls.Add(this.btnAjoutPersonnel);
            this.grpGestion.Controls.Add(this.btnAfficheAbsence);
            this.grpGestion.Controls.Add(this.dgvGestion);
            this.grpGestion.Location = new System.Drawing.Point(12, 12);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Size = new System.Drawing.Size(776, 354);
            this.grpGestion.TabIndex = 1;
            this.grpGestion.TabStop = false;
            this.grpGestion.Text = "Gestion globale";
            // 
            // dgvGestion
            // 
            this.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestion.Location = new System.Drawing.Point(6, 29);
            this.dgvGestion.Name = "dgvGestion";
            this.dgvGestion.Size = new System.Drawing.Size(764, 261);
            this.dgvGestion.TabIndex = 0;
            // 
            // btnAfficheAbsence
            // 
            this.btnAfficheAbsence.Location = new System.Drawing.Point(20, 311);
            this.btnAfficheAbsence.Name = "btnAfficheAbsence";
            this.btnAfficheAbsence.Size = new System.Drawing.Size(123, 23);
            this.btnAfficheAbsence.TabIndex = 1;
            this.btnAfficheAbsence.Text = "Afficher les absences";
            this.btnAfficheAbsence.UseVisualStyleBackColor = true;
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.Controls.Add(this.lblService);
            this.grpPersonnel.Controls.Add(this.lblMail);
            this.grpPersonnel.Controls.Add(this.lblPrenom);
            this.grpPersonnel.Controls.Add(this.lblTel);
            this.grpPersonnel.Controls.Add(this.lnlNom);
            this.grpPersonnel.Controls.Add(this.txtMail);
            this.grpPersonnel.Controls.Add(this.txtPrenom);
            this.grpPersonnel.Controls.Add(this.txtTel);
            this.grpPersonnel.Controls.Add(this.txtNom);
            this.grpPersonnel.Controls.Add(this.cboService);
            this.grpPersonnel.Location = new System.Drawing.Point(12, 372);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(776, 179);
            this.grpPersonnel.TabIndex = 2;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "Gestion du personnel";
            // 
            // btnAjoutPersonnel
            // 
            this.btnAjoutPersonnel.Location = new System.Drawing.Point(331, 311);
            this.btnAjoutPersonnel.Name = "btnAjoutPersonnel";
            this.btnAjoutPersonnel.Size = new System.Drawing.Size(112, 23);
            this.btnAjoutPersonnel.TabIndex = 2;
            this.btnAjoutPersonnel.Text = "Ajouter un personnel";
            this.btnAjoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(469, 311);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(133, 23);
            this.btnModifierPersonnel.TabIndex = 3;
            this.btnModifierPersonnel.Text = "Modifier un personnel";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimmerPersonnel
            // 
            this.btnSupprimmerPersonnel.Location = new System.Drawing.Point(626, 311);
            this.btnSupprimmerPersonnel.Name = "btnSupprimmerPersonnel";
            this.btnSupprimmerPersonnel.Size = new System.Drawing.Size(136, 23);
            this.btnSupprimmerPersonnel.TabIndex = 4;
            this.btnSupprimmerPersonnel.Text = "Supprimmer un personnel";
            this.btnSupprimmerPersonnel.UseVisualStyleBackColor = true;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(606, 72);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(121, 21);
            this.cboService.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(131, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(131, 113);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(371, 35);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(371, 113);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 4;
            // 
            // lnlNom
            // 
            this.lnlNom.AutoSize = true;
            this.lnlNom.Location = new System.Drawing.Point(75, 42);
            this.lnlNom.Name = "lnlNom";
            this.lnlNom.Size = new System.Drawing.Size(35, 13);
            this.lnlNom.TabIndex = 5;
            this.lnlNom.Text = "Nom :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(82, 116);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(310, 41);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(327, 120);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail :";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(537, 75);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Service :";
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.grpPersonnel);
            this.Controls.Add(this.grpGestion);
            this.Name = "FrmGestion";
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.grpGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).EndInit();
            this.grpPersonnel.ResumeLayout(false);
            this.grpPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.DataGridView dgvGestion;
        private System.Windows.Forms.Button btnAfficheAbsence;
        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.Button btnSupprimmerPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnAjoutPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lnlNom;
        private System.Windows.Forms.Label lblService;
    }
}

