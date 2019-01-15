using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVM_Pattern_Sample_Project.Model;
using MVVM_Pattern_Sample_Project.Repositories;
using MVVM_Pattern_Sample_Project.ViewModels;
using Newtonsoft.Json;

namespace MVVM_PatternWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PatientDataRepository patientDataRepository = new PatientDataRepository();
            string json = patientDataRepository.ReadJsonFile();

            PatientModel patientModel = JsonConvert.DeserializeObject<PatientModel>(json);


            Application.Run(new MiniNeoMedForm(new PatientViewModel(), patientDataRepository));
        }
    }
}
