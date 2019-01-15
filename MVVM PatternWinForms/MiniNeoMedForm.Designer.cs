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
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
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
            this.lblDelimitedDiagnostics = new System.Windows.Forms.Label();
            this.txtCommaDelimitedDiagnostics = new System.Windows.Forms.TextBox();
            this.lstboxDiagnostics = new System.Windows.Forms.ListBox();
            this.btnRemoveDiagnostics = new System.Windows.Forms.Button();
            this.btnAddDiagnostics = new System.Windows.Forms.Button();
            this.Allergies = new System.Windows.Forms.TabPage();
            this.lblDelimitedAllergies = new System.Windows.Forms.Label();
            this.txtCommaDelimitedAllergies = new System.Windows.Forms.TextBox();
            this.lstboxAllergies = new System.Windows.Forms.ListBox();
            this.btnRemoveAllergies = new System.Windows.Forms.Button();
            this.btnAddAllergies = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientImage)).BeginInit();
            this.tabCtrlMain.SuspendLayout();
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
            this.pbPatientImage.Click += new System.EventHandler(this.pbPatientImage_Click);
            // 
            // lblFullNameSummary
            // 
            this.lblFullNameSummary.AutoSize = true;
            this.lblFullNameSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameSummary.Location = new System.Drawing.Point(189, 25);
            this.lblFullNameSummary.Name = "lblFullNameSummary";
            this.lblFullNameSummary.Size = new System.Drawing.Size(97, 24);
            this.lblFullNameSummary.TabIndex = 1;
            this.lblFullNameSummary.Text = "Full Name";
            // 
            // lblAgeAndSexSummary
            // 
            this.lblAgeAndSexSummary.AutoSize = true;
            this.lblAgeAndSexSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAndSexSummary.Location = new System.Drawing.Point(189, 55);
            this.lblAgeAndSexSummary.Name = "lblAgeAndSexSummary";
            this.lblAgeAndSexSummary.Size = new System.Drawing.Size(205, 24);
            this.lblAgeAndSexSummary.TabIndex = 2;
            this.lblAgeAndSexSummary.Text = "Age and Sex Summary";
            // 
            // lblDiagnosticsSummary
            // 
            this.lblDiagnosticsSummary.AutoSize = true;
            this.lblDiagnosticsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosticsSummary.Location = new System.Drawing.Point(189, 85);
            this.lblDiagnosticsSummary.Name = "lblDiagnosticsSummary";
            this.lblDiagnosticsSummary.Size = new System.Drawing.Size(186, 24);
            this.lblDiagnosticsSummary.TabIndex = 3;
            this.lblDiagnosticsSummary.Text = "DiagnosticsSummary";
            // 
            // lblAllergiesSummary
            // 
            this.lblAllergiesSummary.AutoSize = true;
            this.lblAllergiesSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergiesSummary.Location = new System.Drawing.Point(189, 115);
            this.lblAllergiesSummary.Name = "lblAllergiesSummary";
            this.lblAllergiesSummary.Size = new System.Drawing.Size(168, 24);
            this.lblAllergiesSummary.TabIndex = 4;
            this.lblAllergiesSummary.Text = "Allergies Summary";
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.Demographics);
            this.tabCtrlMain.Controls.Add(this.Diagnostics);
            this.tabCtrlMain.Controls.Add(this.Allergies);
            this.tabCtrlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCtrlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlMain.Location = new System.Drawing.Point(12, 174);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(539, 282);
            this.tabCtrlMain.TabIndex = 5;
            // 
            // Demographics
            // 
            this.Demographics.BackColor = System.Drawing.Color.LightGray;
            this.Demographics.Controls.Add(this.dtpBirthDate);
            this.Demographics.Controls.Add(this.cmbSex);
            this.Demographics.Controls.Add(this.txtNotes);
            this.Demographics.Controls.Add(this.txtFullName);
            this.Demographics.Controls.Add(this.lblNotes);
            this.Demographics.Controls.Add(this.lblSex);
            this.Demographics.Controls.Add(this.lblBirthDate);
            this.Demographics.Controls.Add(this.lblFullNameDemographics);
            this.Demographics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Demographics.Location = new System.Drawing.Point(4, 33);
            this.Demographics.Name = "Demographics";
            this.Demographics.Padding = new System.Windows.Forms.Padding(3);
            this.Demographics.Size = new System.Drawing.Size(531, 245);
            this.Demographics.TabIndex = 0;
            this.Demographics.Text = "Demographics";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(143, 76);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(264, 26);
            this.dtpBirthDate.TabIndex = 14;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(143, 114);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(264, 28);
            this.cmbSex.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(143, 153);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(264, 52);
            this.txtNotes.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(143, 38);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(264, 26);
            this.txtFullName.TabIndex = 9;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(14, 152);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(14, 122);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(36, 20);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(14, 84);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(74, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Birthdate";
            // 
            // lblFullNameDemographics
            // 
            this.lblFullNameDemographics.AutoSize = true;
            this.lblFullNameDemographics.Location = new System.Drawing.Point(14, 47);
            this.lblFullNameDemographics.Name = "lblFullNameDemographics";
            this.lblFullNameDemographics.Size = new System.Drawing.Size(80, 20);
            this.lblFullNameDemographics.TabIndex = 5;
            this.lblFullNameDemographics.Text = "Full Name";
            // 
            // Diagnostics
            // 
            this.Diagnostics.BackColor = System.Drawing.Color.LightGray;
            this.Diagnostics.Controls.Add(this.lblDelimitedDiagnostics);
            this.Diagnostics.Controls.Add(this.txtCommaDelimitedDiagnostics);
            this.Diagnostics.Controls.Add(this.lstboxDiagnostics);
            this.Diagnostics.Controls.Add(this.btnRemoveDiagnostics);
            this.Diagnostics.Controls.Add(this.btnAddDiagnostics);
            this.Diagnostics.Location = new System.Drawing.Point(4, 33);
            this.Diagnostics.Name = "Diagnostics";
            this.Diagnostics.Padding = new System.Windows.Forms.Padding(3);
            this.Diagnostics.Size = new System.Drawing.Size(531, 245);
            this.Diagnostics.TabIndex = 1;
            this.Diagnostics.Text = "Diagnostics";
            // 
            // lblDelimitedDiagnostics
            // 
            this.lblDelimitedDiagnostics.AutoSize = true;
            this.lblDelimitedDiagnostics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelimitedDiagnostics.Location = new System.Drawing.Point(14, 206);
            this.lblDelimitedDiagnostics.Name = "lblDelimitedDiagnostics";
            this.lblDelimitedDiagnostics.Size = new System.Drawing.Size(139, 20);
            this.lblDelimitedDiagnostics.TabIndex = 6;
            this.lblDelimitedDiagnostics.Text = "Enter Diagnostics:";
            this.lblDelimitedDiagnostics.Visible = false;
            // 
            // txtCommaDelimitedDiagnostics
            // 
            this.txtCommaDelimitedDiagnostics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommaDelimitedDiagnostics.Location = new System.Drawing.Point(159, 203);
            this.txtCommaDelimitedDiagnostics.Name = "txtCommaDelimitedDiagnostics";
            this.txtCommaDelimitedDiagnostics.Size = new System.Drawing.Size(176, 26);
            this.txtCommaDelimitedDiagnostics.TabIndex = 10;
            this.txtCommaDelimitedDiagnostics.Visible = false;
            // 
            // lstboxDiagnostics
            // 
            this.lstboxDiagnostics.BackColor = System.Drawing.SystemColors.Window;
            this.lstboxDiagnostics.FormattingEnabled = true;
            this.lstboxDiagnostics.ItemHeight = 24;
            this.lstboxDiagnostics.Location = new System.Drawing.Point(6, 6);
            this.lstboxDiagnostics.Name = "lstboxDiagnostics";
            this.lstboxDiagnostics.Size = new System.Drawing.Size(519, 172);
            this.lstboxDiagnostics.TabIndex = 4;
            // 
            // btnRemoveDiagnostics
            // 
            this.btnRemoveDiagnostics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDiagnostics.Location = new System.Drawing.Point(443, 201);
            this.btnRemoveDiagnostics.Name = "btnRemoveDiagnostics";
            this.btnRemoveDiagnostics.Size = new System.Drawing.Size(83, 29);
            this.btnRemoveDiagnostics.TabIndex = 3;
            this.btnRemoveDiagnostics.Text = "Remove";
            this.btnRemoveDiagnostics.UseVisualStyleBackColor = true;
            this.btnRemoveDiagnostics.Click += new System.EventHandler(this.btnRemoveDiagnostics_Click);
            // 
            // btnAddDiagnostics
            // 
            this.btnAddDiagnostics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiagnostics.Location = new System.Drawing.Point(350, 201);
            this.btnAddDiagnostics.Name = "btnAddDiagnostics";
            this.btnAddDiagnostics.Size = new System.Drawing.Size(83, 29);
            this.btnAddDiagnostics.TabIndex = 2;
            this.btnAddDiagnostics.UseVisualStyleBackColor = true;
            this.btnAddDiagnostics.Click += new System.EventHandler(this.btnAddDiagnostics_Click);
            // 
            // Allergies
            // 
            this.Allergies.BackColor = System.Drawing.Color.LightGray;
            this.Allergies.Controls.Add(this.lblDelimitedAllergies);
            this.Allergies.Controls.Add(this.txtCommaDelimitedAllergies);
            this.Allergies.Controls.Add(this.lstboxAllergies);
            this.Allergies.Controls.Add(this.btnRemoveAllergies);
            this.Allergies.Controls.Add(this.btnAddAllergies);
            this.Allergies.Location = new System.Drawing.Point(4, 33);
            this.Allergies.Name = "Allergies";
            this.Allergies.Size = new System.Drawing.Size(531, 245);
            this.Allergies.TabIndex = 2;
            this.Allergies.Text = "Allergies";
            // 
            // lblDelimitedAllergies
            // 
            this.lblDelimitedAllergies.AutoSize = true;
            this.lblDelimitedAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelimitedAllergies.Location = new System.Drawing.Point(19, 205);
            this.lblDelimitedAllergies.Name = "lblDelimitedAllergies";
            this.lblDelimitedAllergies.Size = new System.Drawing.Size(116, 20);
            this.lblDelimitedAllergies.TabIndex = 11;
            this.lblDelimitedAllergies.Text = "Enter Allergies:";
            this.lblDelimitedAllergies.Visible = false;
            // 
            // txtCommaDelimitedAllergies
            // 
            this.txtCommaDelimitedAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommaDelimitedAllergies.Location = new System.Drawing.Point(159, 203);
            this.txtCommaDelimitedAllergies.Name = "txtCommaDelimitedAllergies";
            this.txtCommaDelimitedAllergies.Size = new System.Drawing.Size(176, 26);
            this.txtCommaDelimitedAllergies.TabIndex = 12;
            this.txtCommaDelimitedAllergies.Visible = false;
            // 
            // lstboxAllergies
            // 
            this.lstboxAllergies.FormattingEnabled = true;
            this.lstboxAllergies.ItemHeight = 24;
            this.lstboxAllergies.Location = new System.Drawing.Point(6, 6);
            this.lstboxAllergies.Name = "lstboxAllergies";
            this.lstboxAllergies.Size = new System.Drawing.Size(519, 172);
            this.lstboxAllergies.TabIndex = 6;
            // 
            // btnRemoveAllergies
            // 
            this.btnRemoveAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllergies.Location = new System.Drawing.Point(443, 201);
            this.btnRemoveAllergies.Name = "btnRemoveAllergies";
            this.btnRemoveAllergies.Size = new System.Drawing.Size(83, 29);
            this.btnRemoveAllergies.TabIndex = 5;
            this.btnRemoveAllergies.Text = "Remove";
            this.btnRemoveAllergies.UseVisualStyleBackColor = true;
            this.btnRemoveAllergies.Click += new System.EventHandler(this.btnRemoveAllergies_Click);
            // 
            // btnAddAllergies
            // 
            this.btnAddAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllergies.Location = new System.Drawing.Point(350, 201);
            this.btnAddAllergies.Name = "btnAddAllergies";
            this.btnAddAllergies.Size = new System.Drawing.Size(83, 29);
            this.btnAddAllergies.TabIndex = 4;
            this.btnAddAllergies.UseVisualStyleBackColor = true;
            this.btnAddAllergies.Click += new System.EventHandler(this.btnAddAllergies_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(407, 462);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(140, 30);
            this.btnSaveAndClose.TabIndex = 2;
            this.btnSaveAndClose.Text = "&Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // MiniNeoMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(563, 504);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.lblAllergiesSummary);
            this.Controls.Add(this.lblDiagnosticsSummary);
            this.Controls.Add(this.lblAgeAndSexSummary);
            this.Controls.Add(this.lblFullNameSummary);
            this.Controls.Add(this.pbPatientImage);
            this.Name = "MiniNeoMedForm";
            this.Text = "Mini-NeoMed";
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientImage)).EndInit();
            this.tabCtrlMain.ResumeLayout(false);
            this.Demographics.ResumeLayout(false);
            this.Demographics.PerformLayout();
            this.Diagnostics.ResumeLayout(false);
            this.Diagnostics.PerformLayout();
            this.Allergies.ResumeLayout(false);
            this.Allergies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPatientImage;
        private System.Windows.Forms.Label lblFullNameSummary;
        private System.Windows.Forms.Label lblAgeAndSexSummary;
        private System.Windows.Forms.Label lblDiagnosticsSummary;
        private System.Windows.Forms.Label lblAllergiesSummary;
        private System.Windows.Forms.TabControl tabCtrlMain;
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
        private System.Windows.Forms.Label lblDelimitedDiagnostics;
        private System.Windows.Forms.TextBox txtCommaDelimitedDiagnostics;
        private System.Windows.Forms.Label lblDelimitedAllergies;
        private System.Windows.Forms.TextBox txtCommaDelimitedAllergies;
    }
}

