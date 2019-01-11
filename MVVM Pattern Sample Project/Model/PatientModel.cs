using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM_Pattern_Sample_Project.Properties;

namespace MVVM_Pattern_Sample_Project.Model
{

    public class PatientModel
    {
        public string FullName { get; set; }

        public string PictureName { get; set; }

        public string BirthDate { get; set; }

        public string Sex { get; set; }


        public string Notes { get; set; }

        public ObservableCollection<string> Diagnostics { get; set; }
        
        public ObservableCollection<string> Allergies { get; set; }

        
    }
}
