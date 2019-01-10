using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using MVVM_Pattern_Sample_Project.Model;
using Newtonsoft.Json;

namespace MVVM_Pattern_Sample_Project.ViewModels
{
    public class PatientViewModel : PatientModel
    {

        public ObservableCollection<PatientModel> PatientSummary { get; set; }
        public new ObservableCollection<string> Diagnostics { get; set; }

        public new ObservableCollection<string> Allergies { get; set; }


        public PatientViewModel()
        {
            PatientSummary = new ObservableCollection<PatientModel>();
            Diagnostics = new ObservableCollection<string>();
            Allergies = new ObservableCollection<string>();
            LoadPatient();
            GenerateDiagnosticsSummaryText();
            GenerateAllergiesSummaryText();
        }

        #region Methods

        public void LoadPatient()
        {
            using (StreamReader r = new StreamReader("Data/patientData.json"))
            {
                string json = r.ReadToEnd();
                var patientList = JsonConvert.DeserializeObject<PatientModel>(json);

                PatientSummary.Add(patientList);

                foreach (var patientDiagnostic in patientList.Diagnostics)
                {
                    Diagnostics.Add(patientDiagnostic);
                }

                foreach (var patientallergy in patientList.Allergies)
                {
                    Allergies.Add(patientallergy);
                }
            }
        }

        private void GenerateDiagnosticsSummaryText()
        {
            if (Diagnostics.Count == 1)
            {
                PatientSummary.FirstOrDefault().DiagnosticsSummary =
                    $"The patient has {Diagnostics[0]}.";
            }
            else if (Diagnostics.Count > 1)
            {
                PatientSummary.FirstOrDefault().DiagnosticsSummary =
               $"The patient has {Diagnostics[0]} and {Diagnostics[1]}.";
            }
            else
            {
                PatientSummary.FirstOrDefault().DiagnosticsSummary =
                    "The patient has no diagnostics.";
            }


        }

        private void GenerateAllergiesSummaryText()
        {
            if (Allergies.Count == 1)
            {
                PatientSummary.FirstOrDefault().AllergiesSummary =
                    $"The patient is allergic to {Allergies[0]}.";
            }
            else if (Allergies.Count > 1)
            {
                PatientSummary.FirstOrDefault().AllergiesSummary =
                    $"The patient is allergic to {Allergies[0]} and {Allergies[1]}.";
            }
            else
            {
                PatientSummary.FirstOrDefault().AllergiesSummary =
                    "The patient has no allergies.";
            }


        }

        #endregion

    }


}
