using Feedback_Application.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Feedback_Application
{
    public class APIService
    {

        public HttpClient client { get; set; }
        public ConfigModel configModel { get; set; }

        public APIService(ConfigModel cfm)
        {
            client = new HttpClient();
            configModel = cfm;
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
                var response = await client.GetAsync(configModel.IPAddress + activateDeviceEndpoint);
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
            string sendUserResponse = "response/save";
            var customUserBody = new
            {
                CampaignId = currentSession.CampaignId,
                UserResponses = currentSession.UserResponses.ToArray()
            };

            var customJson = JsonConvert.SerializeObject(customUserBody);

            var content = new StringContent(customJson.ToString(), Encoding.UTF8, "application/json");

            var response = client.PostAsync(configModel.IPAddress + sendUserResponse, content).Result;

            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Nije se sesija sinhronizovala sa serverom");
            }
        }

    }
}
