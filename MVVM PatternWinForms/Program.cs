using System;
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
            
            Application.Run(new MiniNeoMedForm(new PatientViewModel(), patientDataRepository));
        }
    }
}
