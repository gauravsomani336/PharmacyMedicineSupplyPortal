using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebProj.Models;

namespace WebProj.Repository
{
    public class CreateSchedules : ISchedule
    {
        
   
        private readonly Uri BaseAddressSchedule;
        private readonly IHttpContextAccessor _httpContext;

        public CreateSchedules(IConfiguration configuration, IHttpContextAccessor httpContext)
        {

            BaseAddressSchedule = new Uri(configuration.GetSection("ApiBaseAddresses:Schedule").Value);
            _httpContext = httpContext;
        }

        public async Task<List<Schedule>> CreateSchedule(DateTime date)
        {
            using (var client = new HttpClient())
                    {
               client.BaseAddress = BaseAddressSchedule;
               // client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);

                string startdate = date.Year + "-" + date.Month + "-" + date.Day;

                HttpResponseMessage res = await client.GetAsync("RepSchedule?d=" + startdate);

                if (res.IsSuccessStatusCode)
                {
                    var apiResponse = res.Content.ReadAsStringAsync().Result;
                    List<Schedule> schedule = JsonConvert.DeserializeObject<List<Schedule>>(apiResponse);
                    return schedule;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
