namespace MVVM_PatternWinForms
{
    partial class MiniNeoMedForm
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
            this.pbPatientImage = new System.Windows.Forms.PictureBox();
            this.lblFullNameSummary = new System.Windows.Forms.Label();
            this.lblAgeAndSexSummary = new System.Windows.Forms.Label();
            this.lblDiagnosticsSummary = new System.Windows.Forms.Label();
            this.lblAllergiesSummary = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Demographics = new System.Windows.Forms.TabPage();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblFullNameDemographics = new System.Windows.Forms.Label();
            this.Diagnostics = new System.Windows.Forms.TabPage();
            this.lstboxDiagnostics = new System.Windows.Forms.ListBox();
            this.btnRemoveDiagnostics = new System.Windows.Forms.Button();
            this.btnAddDiagnostics = new System.Windows.Forms.Button();
            this.Allergies = new System.Windows.Forms.TabPage();
            this.lstboxAllergies = new System.Windows.Forms.ListBox();
            this.btnRemoveAllergies = new System.Windows.Forms.Button();
            this.btnAddAllergies = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Demographics.SuspendLayout();
            this.Diagnostics.SuspendLayout();
            this.Allergies.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPatientImage
            // 
            this.pbPatientImage.Location = new System.Drawing.Point(12, 12);
            this.pbPatientImage.Name = "pbPatientImage";
            this.pbPatientImage.Size = new System.Drawing.Size(139, 134);
            this.pbPatientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatientImage.TabIndex = 0;
            this.pbPatientImage.TabStop = false;
            // 
            // lblFullNameSummary
            // 
            this.lblFullNameSummary.AutoSize = true;
            this.lblFullNameSummary.Location = new System.Drawing.Point(237, 25);
            this.lblFullNameSummary.Name = "lblFullNameSummary";
            this.lblFullNameSummary.Size = new System.Drawing.Size(54, 13);
            this.lblFullNameSummary.TabIndex = 1;
            this.lblFullNameSummary.Text = "Full Name";
            // 
            // lblAgeAndSexSummary
            // 
            this.lblAgeAndSexSummary.AutoSize = true;
            this.lblAgeAndSexSummary.Location = new System.Drawing.Point(237, 55);
            this.lblAgeAndSexSummary.Name = "lblAgeAndSexSummary";
            this.lblAgeAndSexSummary.Size = new System.Drawing.Size(114, 13);
            this.lblAgeAndSexSummary.TabIndex = 2;
            this.lblAgeAndSexSummary.Text = "Age and Sex Summary";
            // 
            // lblDiagnosticsSummary
            // 
            this.lblDiagnosticsSummary.AutoSize = true;
            this.lblDiagnosticsSummary.Location = new System.Drawing.Point(237, 85);
            this.lblDiagnosticsSummary.Name = "lblDiagnosticsSummary";
            this.lblDiagnosticsSummary.Size = new System.Drawing.Size(105, 13);
            this.lblDiagnosticsSummary.TabIndex = 3;
            this.lblDiagnosticsSummary.Text = "DiagnosticsSummary";
            // 
            // lblAllergiesSummary
            // 
            this.lblAllergiesSummary.AutoSize = true;
            this.lblAllergiesSummary.Location = new System.Drawing.Point(237, 115);
            this.lblAllergiesSummary.Name = "lblAllergiesSummary";
            this.lblAllergiesSummary.Size = new System.Drawing.Size(92, 13);
            this.lblAllergiesSummary.TabIndex = 4;
            this.lblAllergiesSummary.Text = "Allergies Summary";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Demographics);
            this.tabControl1.Controls.Add(this.Diagnostics);
            this.tabControl1.Controls.Add(this.Allergies);
            this.tabControl1.Location = new System.Drawing.Point(12, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 264);
            this.tabControl1.TabIndex = 5;
            // 
            // Demographics
            // 
            this.Demographics.Controls.Add(this.dtpBirthDate);
            this.Demographics.Controls.Add(this.cmbSex);
            this.Demographics.Controls.Add(this.txtNotes);
            this.Demographics.Controls.Add(this.txtFullName);
            this.Demographics.Controls.Add(this.lblNotes);
            this.Demographics.Controls.Add(this.lblSex);
            this.Demographics.Controls.Add(this.lblBirthDate);
            this.Demographics.Controls.Add(this.lblFullNameDemographics);
            this.Demographics.Location = new System.Drawing.Point(4, 22);
            this.Demographics.Name = "Demographics";
            this.Demographics.Padding = new System.Windows.Forms.Padding(3);
            this.Demographics.Size = new System.Drawing.Size(531, 238);
            this.Demographics.TabIndex = 0;
            this.Demographics.Text = "Demographics";
            this.Demographics.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(71, 76);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(264, 20);
            this.dtpBirthDate.TabIndex = 14;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(71, 114);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(264, 21);
            this.cmbSex.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(71, 153);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(264, 52);
            this.txtNotes.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(71, 38);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(264, 20);
            this.txtFullName.TabIndex = 9;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(6, 152);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(6, 122);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 84);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Birthdate";
            // 
            // lblFullNameDemographics
            // 
            this.lblFullNameDemographics.AutoSize = true;
            this.lblFullNameDemographics.Location = new System.Drawing.Point(6, 47);
            this.lblFullNameDemographics.Name = "lblFullNameDemographics";
            this.lblFullNameDemographics.Size = new System.Drawing.Size(54, 13);
            this.lblFullNameDemographics.TabIndex = 5;
            this.lblFullNameDemographics.Text = "Full Name";
            // 
            // Diagnostics
            // 
            this.Diagnostics.Controls.Add(this.lstboxDiagnostics);
            this.Diagnostics.Controls.Add(this.btnRemoveDiagnostics);
            this.Diagnostics.Controls.Add(this.btnAddDiagnostics);
            this.Diagnostics.Location = new System.Drawing.Point(4, 22);
            this.Diagnostics.Name = "Diagnostics";
            this.Diagnostics.Padding = new System.Windows.Forms.Padding(3);
            this.Diagnostics.Size = new System.Drawing.Size(531, 238);
            this.Diagnostics.TabIndex = 1;
            this.Diagnostics.Text = "Diagnostics";
            this.Diagnostics.UseVisualStyleBackColor = true;
            // 
            // lstboxDiagnostics
            // 
            this.lstboxDiagnostics.FormattingEnabled = true;
            this.lstboxDiagnostics.Location = new System.Drawing.Point(6, 6);
            this.lstboxDiagnostics.Name = "lstboxDiagnostics";
            this.lstboxDiagnostics.Size = new System.Drawing.Size(519, 186);
            this.lstboxDiagnostics.TabIndex = 4;
            // 
            // btnRemoveDiagnostics
            // 
            this.btnRemoveDiagnostics.Location = new System.Drawing.Point(451, 209);
            this.btnRemoveDiagnostics.Name = "btnRemoveDiagnostics";
            this.btnRemoveDiagnostics.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDiagnostics.TabIndex = 3;
            this.btnRemoveDiagnostics.Text = "Remove";
            this.btnRemoveDiagnostics.UseVisualStyleBackColor = true;
            // 
            // btnAddDiagnostics
            // 
            this.btnAddDiagnostics.Location = new System.Drawing.Point(360, 209);
            this.btnAddDiagnostics.Name = "btnAddDiagnostics";
            this.btnAddDiagnostics.Size = new System.Drawing.Size(75, 23);
            this.btnAddDiagnostics.TabIndex = 2;
            this.btnAddDiagnostics.Text = "Add";
            this.btnAddDiagnostics.UseVisualStyleBackColor = true;
            // 
            // Allergies
            // 
            this.Allergies.Controls.Add(this.lstboxAllergies);
            this.Allergies.Controls.Add(this.btnRemoveAllergies);
            this.Allergies.Controls.Add(this.btnAddAllergies);
            this.Allergies.Location = new System.Drawing.Point(4, 22);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(531, 238);
            this.Allergies.TabIndex = 2;
            this.Allergies.Text = "Allergies";
            this.Allergies.UseVisualStyleBackColor = true;
            // 
            // lstboxAllergies
            // 
            this.lstboxAllergies.FormattingEnabled = true;
            this.lstboxAllergies.Location = new System.Drawing.Point(6, 6);
            this.lstboxAllergies.Name = "lstboxAllergies";
            this.lstboxAllergies.Size = new System.Drawing.Size(519, 186);
            this.lstboxAllergies.TabIndex = 6;
            // 
            // btnRemoveAllergies
            // 
            this.btnRemoveAllergies.Location = new System.Drawing.Point(451, 209);
            this.btnRemoveAllergies.Name = "btnRemoveAllergies";
            this.btnRemoveAllergies.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllergies.TabIndex = 5;
            this.btnRemoveAllergies.Text = "Remove";
            this.btnRemoveAllergies.UseVisualStyleBackColor = true;
            // 
            // btnAddAllergies
            // 
            this.btnAddAllergies.Location = new System.Drawing.Point(360, 209);
            this.btnAddAllergies.Name = "btnAddAllergies";
            this.btnAddAllergies.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllergies.TabIndex = 4;
            this.btnAddAllergies.Text = "Add";
            this.btnAddAllergies.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(431, 462);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(111, 23);
            this.btnSaveAndClose.TabIndex = 2;
            this.btnSaveAndClose.Text = "Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            // 
            // MiniNeoMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 497);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAllergiesSummary);
            this.Controls.Add(this.lblDiagnosticsSummary);
            this.Controls.Add(this.lblAgeAndSexSummary);
            this.Controls.Add(this.lblFullNameSummary);
            this.Controls.Add(this.pbPatientImage);
            this.Name = "MiniNeoMedForm";
            this.Text = "Mini-NeoMed";
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Demographics.ResumeLayout(false);
            this.Demographics.PerformLayout();
            this.Diagnostics.ResumeLayout(false);
            this.Allergies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPatientImage;
        private System.Windows.Forms.Label lblFullNameSummary;
        private System.Windows.Forms.Label lblAgeAndSexSummary;
        private System.Windows.Forms.Label lblDiagnosticsSummary;
        private System.Windows.Forms.Label lblAllergiesSummary;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Demographics;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblFullNameDemographics;
        private System.Windows.Forms.TabPage Diagnostics;
        private System.Windows.Forms.ListBox lstboxDiagnostics;
        private System.Windows.Forms.Button btnRemoveDiagnostics;
        private System.Windows.Forms.Button btnAddDiagnostics;
        private System.Windows.Forms.TabPage Allergies;
        private System.Windows.Forms.ListBox lstboxAllergies;
        private System.Windows.Forms.Button btnRemoveAllergies;
        private System.Windows.Forms.Button btnAddAllergies;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}

