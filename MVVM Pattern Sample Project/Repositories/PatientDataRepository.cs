using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Pattern_Sample_Project.Model;
using MVVM_Pattern_Sample_Project.Properties;
using Newtonsoft.Json;

namespace MVVM_Pattern_Sample_Project.Repositories
{
    public class PatientDataRepository
    {

        public void WriteToJsonFile(PatientModel Model)
        {

            var output = JsonConvert.SerializeObject(Model);
            output = output.Replace("[{", "{");
            output = output.Replace("}]", "}");

            File.WriteAllText(Path.GetFullPath(Environment.CurrentDirectory + "/Data" + "/patientData.json"), output);

        }


        public string ReadJsonFile()
        {
            using (StreamReader reader = new StreamReader(Environment.CurrentDirectory + "/Data" + "/patientData.json"))
            {
                string json;

                try
                {
                    json = reader.ReadToEnd();
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }

                return json;
            }

        }








    }
}
