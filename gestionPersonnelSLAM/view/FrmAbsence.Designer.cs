namespace gestionPersonnelSLAM
{
    partial class FrmAbsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.grpGestionAbsence = new System.Windows.Forms.GroupBox();
            this.btnSupprimmerAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnAffichePersonnel = new System.Windows.Forms.Button();
            this.grpAbsence = new System.Windows.Forms.GroupBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grpGestionAbsence.SuspendLayout();
            this.grpAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 32);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.Size = new System.Drawing.Size(764, 268);
            this.dgvAbsence.TabIndex = 0;
            // 
            // grpGestionAbsence
            // 
            this.grpGestionAbsence.Controls.Add(this.btnSupprimmerAbsence);
            this.grpGestionAbsence.Controls.Add(this.btnModifierAbsence);
            this.grpGestionAbsence.Controls.Add(this.btnAjoutAbsence);
            this.grpGestionAbsence.Controls.Add(this.btnAffichePersonnel);
            this.grpGestionAbsence.Controls.Add(this.dgvAbsence);
            this.grpGestionAbsence.Location = new System.Drawing.Point(12, 12);
            this.grpGestionAbsence.Name = "grpGestionAbsence";
            this.grpGestionAbsence.Size = new System.Drawing.Size(776, 372);
            this.grpGestionAbsence.TabIndex = 1;
            this.grpGestionAbsence.TabStop = false;
            this.grpGestionAbsence.Text = "gestionDes Absences";
            // 
            // btnSupprimmerAbsence
            // 
            this.btnSupprimmerAbsence.Location = new System.Drawing.Point(621, 331);
            this.btnSupprimmerAbsence.Name = "btnSupprimmerAbsence";
            this.btnSupprimmerAbsence.Size = new System.Drawing.Size(137, 23);
            this.btnSupprimmerAbsence.TabIndex = 4;
            this.btnSupprimmerAbsence.Text = "Supprimmer une absence";
            this.btnSupprimmerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimmerAbsence.Click += new System.EventHandler(this.btnSupprimmerAbsence_Click);
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(481, 331);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(118, 23);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.Text = "Modifier une absence";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(335, 331);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(121, 23);
            this.btnAjoutAbsence.TabIndex = 2;
            this.btnAjoutAbsence.Text = "Ajouter une absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAjoutAbsence.Click += new System.EventHandler(this.btnAjoutAbsence_Click);
            // 
            // btnAffichePersonnel
            // 
            this.btnAffichePersonnel.Location = new System.Drawing.Point(28, 331);
            this.btnAffichePersonnel.Name = "btnAffichePersonnel";
            this.btnAffichePersonnel.Size = new System.Drawing.Size(114, 23);
            this.btnAffichePersonnel.TabIndex = 1;
            this.btnAffichePersonnel.Text = "Afficher le personnel";
            this.btnAffichePersonnel.UseVisualStyleBackColor = true;
            this.btnAffichePersonnel.Click += new System.EventHandler(this.btnAffichePersonnel_Click);
            // 
            // grpAbsence
            // 
            this.grpAbsence.Controls.Add(this.btnAnnuler);
            this.grpAbsence.Controls.Add(this.btnEnregistrer);
            this.grpAbsence.Controls.Add(this.lblMotif);
            this.grpAbsence.Controls.Add(this.lblFin);
            this.grpAbsence.Controls.Add(this.lblDebut);
            this.grpAbsence.Controls.Add(this.cboMotif);
            this.grpAbsence.Controls.Add(this.dtpFin);
            this.grpAbsence.Controls.Add(this.dtpDebut);
            this.grpAbsence.Location = new System.Drawing.Point(12, 390);
            this.grpAbsence.Name = "grpAbsence";
            this.grpAbsence.Size = new System.Drawing.Size(776, 186);
            this.grpAbsence.TabIndex = 2;
            this.grpAbsence.TabStop = false;
            this.grpAbsence.Text = "Gestion des absences";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(478, 67);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif :";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(77, 125);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(65, 13);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Date de fin :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(61, 60);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDebut.TabIndex = 3;
            this.lblDebut.Text = "Date de debut :";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(520, 67);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 2;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(154, 125);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 1;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(154, 60);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 0;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(481, 122);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(590, 122);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.grpAbsence);
            this.Controls.Add(this.grpGestionAbsence);
            this.Name = "FrmAbsence";
            this.Text = "FrmAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.grpGestionAbsence.ResumeLayout(false);
            this.grpAbsence.ResumeLayout(false);
            this.grpAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.GroupBox grpGestionAbsence;
        private System.Windows.Forms.GroupBox grpAbsence;
        private System.Windows.Forms.Button btnSupprimmerAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnAffichePersonnel;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}