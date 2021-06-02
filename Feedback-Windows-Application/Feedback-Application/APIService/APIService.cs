using Feedback_Application.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Feedback_Application.DatabaseService;

namespace Feedback_Application
{
    public class APIService
    {

        public HttpClient client { get; set; }
        public ConfigModel configModel { get; set; }
        public FADBService DbService { get; set; }

        public APIService(ConfigModel cfm)
        {
            client = new HttpClient();
            configModel = cfm;
            DbService = new FADBService();

        }

        public async Task<Campaign> GetCampaingForDevice(int campaignId)
        {
            try
            {
                string getCampaignEndpoint = "campaign/"+campaignId.ToString();
                var response = await client.GetAsync(configModel.IPAddress + getCampaignEndpoint);
                if (response.IsSuccessStatusCode)
                {
                    Campaign cmpgn = JsonConvert.DeserializeObject<Campaign>(await response.Content.ReadAsStringAsync());
                    return cmpgn;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public async Task<ActivateDeviceModel> ActivateDevice (string installationCode)
        {
            try
            { 
                string activateDeviceEndpoint = "device/activate/"+installationCode;
                var response = await client.PostAsync(configModel.IPAddress + activateDeviceEndpoint, null);
                if (response.IsSuccessStatusCode)
                {
                    ActivateDeviceModel adm = JsonConvert.DeserializeObject<ActivateDeviceModel>(await response.Content.ReadAsStringAsync());
                    return adm;
                }
                else
                {
                    return null;
                }
             }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void SendUserResponseToServer(Session currentSession)
        {
            try
            {
                string sendUserResponse = "device/response/save";
                Random r = new Random();
                var configFile = HelperMethods.GetConfigFile();
                var customUserBody = new
                {
                    CampaignId = currentSession.CampaignId,
                    Duration = r.Next(60, 80),
                    DeviceId = configFile.DeviceId,
                    UserResponses = currentSession.UserResponses.ToArray()
                };

                var customJson = JsonConvert.SerializeObject(customUserBody);

                var content = new StringContent(customJson.ToString(), Encoding.UTF8, "application/json");

                var response = client.PostAsync(configModel.IPAddress + sendUserResponse, content).Result;

                if(!response.IsSuccessStatusCode)
                {
                    DbService.SaveCurrentSession(currentSession);
                }
                else
                {
                    var sessions = DbService.FetchNotSyncedSessions();
                    foreach(var session in sessions)
                    {
                        customUserBody = new
                        {
                            CampaignId = currentSession.CampaignId,
                            Duration = r.Next(60, 80),
                            DeviceId = configFile.DeviceId,
                            UserResponses = session.UserResponses.ToArray()
                        };

                        customJson = JsonConvert.SerializeObject(customUserBody);

                        content = new StringContent(customJson.ToString(), Encoding.UTF8, "application/json");

                        response = client.PostAsync(configModel.IPAddress + sendUserResponse, content).Result;

                    }
                }

            }
            catch(Exception)
            {
                DbService.SaveCurrentSession(currentSession);
            }
        }

    }
}
