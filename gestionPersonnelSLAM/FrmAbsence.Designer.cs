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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpGestionAbsence = new System.Windows.Forms.GroupBox();
            this.grpAbsence = new System.Windows.Forms.GroupBox();
            this.btnAffichePersonnel = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimmerAbsence = new System.Windows.Forms.Button();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGestionAbsence.SuspendLayout();
            this.grpAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpGestionAbsence
            // 
            this.grpGestionAbsence.Controls.Add(this.btnSupprimmerAbsence);
            this.grpGestionAbsence.Controls.Add(this.btnModifierAbsence);
            this.grpGestionAbsence.Controls.Add(this.btnAjoutAbsence);
            this.grpGestionAbsence.Controls.Add(this.btnAffichePersonnel);
            this.grpGestionAbsence.Controls.Add(this.dataGridView1);
            this.grpGestionAbsence.Location = new System.Drawing.Point(12, 12);
            this.grpGestionAbsence.Name = "grpGestionAbsence";
            this.grpGestionAbsence.Size = new System.Drawing.Size(776, 372);
            this.grpGestionAbsence.TabIndex = 1;
            this.grpGestionAbsence.TabStop = false;
            this.grpGestionAbsence.Text = "gestionDes Absences";
            // 
            // grpAbsence
            // 
            this.grpAbsence.Controls.Add(this.lblMotif);
            this.grpAbsence.Controls.Add(this.lblFin);
            this.grpAbsence.Controls.Add(this.lblDebut);
            this.grpAbsence.Controls.Add(this.cboMotif);
            this.grpAbsence.Controls.Add(this.dtpFin);
            this.grpAbsence.Controls.Add(this.dtpDebut);
            this.grpAbsence.Location = new System.Drawing.Point(12, 390);
            this.grpAbsence.Name = "grpAbsence";
            this.grpAbsence.Size = new System.Drawing.Size(776, 214);
            this.grpAbsence.TabIndex = 2;
            this.grpAbsence.TabStop = false;
            this.grpAbsence.Text = "Gestion des absences";
            // 
            // btnAffichePersonnel
            // 
            this.btnAffichePersonnel.Location = new System.Drawing.Point(28, 331);
            this.btnAffichePersonnel.Name = "btnAffichePersonnel";
            this.btnAffichePersonnel.Size = new System.Drawing.Size(114, 23);
            this.btnAffichePersonnel.TabIndex = 1;
            this.btnAffichePersonnel.Text = "Afficher le personnel";
            this.btnAffichePersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(335, 331);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(121, 23);
            this.btnAjoutAbsence.TabIndex = 2;
            this.btnAjoutAbsence.Text = "Ajouter une absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(481, 331);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(118, 23);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.Text = "Modifier une absence";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimmerAbsence
            // 
            this.btnSupprimmerAbsence.Location = new System.Drawing.Point(621, 331);
            this.btnSupprimmerAbsence.Name = "btnSupprimmerAbsence";
            this.btnSupprimmerAbsence.Size = new System.Drawing.Size(137, 23);
            this.btnSupprimmerAbsence.TabIndex = 4;
            this.btnSupprimmerAbsence.Text = "Supprimmer une absence";
            this.btnSupprimmerAbsence.UseVisualStyleBackColor = true;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(154, 60);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 0;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(154, 125);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 1;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(523, 86);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 2;
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
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(77, 125);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(65, 13);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Date de fin :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(481, 89);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif :";
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.grpAbsence);
            this.Controls.Add(this.grpGestionAbsence);
            this.Name = "FrmAbsence";
            this.Text = "FrmAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGestionAbsence.ResumeLayout(false);
            this.grpAbsence.ResumeLayout(false);
            this.grpAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}