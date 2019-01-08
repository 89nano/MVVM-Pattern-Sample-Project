using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<string> Diagnostics { get; set; }

        public ObservableCollection<string> Allergies { get; set; }


        public PatientViewModel()
        {
            Diagnostics = new ObservableCollection<string>();
            Allergies = new ObservableCollection<string>();
            LoadPatient();
        }


        public void LoadPatient()
        {
            using (StreamReader r = new StreamReader("Data/patientData.json"))
            {
                string json = r.ReadToEnd();
                var patientList = JsonConvert.DeserializeObject<PatientModel>(json);


                foreach (var patientDiagnostic in patientList.Diagnostics)
                {
                    Diagnostics.Add(patientDiagnostic);
                }

                foreach (var patientallergy in patientList.Allergies)
                {
                    Allergies.Add(patientallergy);
                }


                FullName = patientList.FullName;
            }
        }



    }


}
