using Feedback_Application.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Feedback_Application
{
    public class HelperMethods
    {

        public static void CreateConfigFile(ConfigModel  configModel)
        {
            try
            {
                string json = JsonConvert.SerializeObject(configModel);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\config.json", json);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static ConfigModel GetConfigFile()
        {
            try
            {
                string json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\config.json");
                ConfigModel cfm = JsonConvert.DeserializeObject<ConfigModel>(json);
                return cfm;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        
        
        public static bool IsConfigFilePresent()
        {
            return File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\config.json");
        }


    }
}
