using Newtonsoft.Json;
using WebProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebProj.Repository
{
    public class LoginPortal : ILoginPortal
    {
        public async Task<Authorize> GetToken(string name, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44366/");
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponse = await client.GetAsync("api/UserModels?username="+name+"&password="+password);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var apiResponse = await httpResponse.Content.ReadAsStringAsync();
                    Authorize res = JsonConvert.DeserializeObject<Authorize>(apiResponse);
                    return res;
                }
            }

            return null;
        }

        public async Task<string> UserRegistration(User user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44366/");
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                HttpResponseMessage httpResponse = await client.PostAsync("api/UserModels", content);


                if (httpResponse.IsSuccessStatusCode)
                {
                    var apiResponse = await httpResponse.Content.ReadAsStringAsync();
                    string res = JsonConvert.DeserializeObject<string>(apiResponse);
                    return res;
                }
            }

            return null;
        }
    }
}
