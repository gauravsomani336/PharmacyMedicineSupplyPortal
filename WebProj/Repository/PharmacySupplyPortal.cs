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
    public class PharmacySupplyPortal : IPharmacySupplyPortal
    {
        private async Task<List<Stock>> GetMedicineStocks()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44393/");
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("api/MedicineStocks");

                if (res.IsSuccessStatusCode)
                {
                    var apiResponse = res.Content.ReadAsStringAsync().Result;
                    List<Stock> medicineStock = JsonConvert.DeserializeObject<List<Stock>>(apiResponse);
                    return medicineStock;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<MedicineDemand>> GetMedicineDemand()
        {
            var medicineStocks = await GetMedicineStocks();

            List<MedicineDemand> medicineDemand = new List<MedicineDemand>();

            if (medicineStocks != null)
            {
                foreach (var item in medicineStocks)
                {
                    medicineDemand.Add(new MedicineDemand { medicineName = item.name, demandCount = 0 });
                }

                return medicineDemand;
            }
            else
            {
                return null;
            }
        }


        public async Task<List<PharmacyMedicineSupply>> GetSupplies(List<MedicineDemand> medicineDemand)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44396/");
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                StringContent content = new StringContent(JsonConvert.SerializeObject(medicineDemand), Encoding.UTF8, "application/json");

                HttpResponseMessage httpResponse = await client.PostAsync("api/PharmacySupply", content);


                if (httpResponse.IsSuccessStatusCode)
                {
                    var apiResponse = await httpResponse.Content.ReadAsStringAsync();
                    List<PharmacyMedicineSupply> supplies = JsonConvert.DeserializeObject<List<PharmacyMedicineSupply>>(apiResponse);
                    return supplies;
                }
            }

            return null;
        }

    }
}
