using Newtonsoft.Json;
using PharmacyMedicineSupplyApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PharmacyMedicineSupplyApi.Repository
{
    public class SupplyRepo:ISupplyRepo
    {
        string Baseurl = "https://localhost:44393/";
        public readonly PharmacyNames pnames = new PharmacyNames();

        List<PharmacyMedicineSupply> p = new List<PharmacyMedicineSupply>();

        // Gets the list of Pharmacy from PharmacyData File.
        public List<String> GetListOfPharmacy()
        {
            return pnames.pharmacies;
        }

        // Accesses StockAPI and distributes the stock equally among the pharmacies.
        public async Task<List<PharmacyMedicineSupply>> GetPharmacySupply(List<MedicineDemand> medicineDemand)
        {
            try
            {
                List<Stock> medStock= await GetMedicineStock();
                List<MedicineSupplyCount> msplist = new List<MedicineSupplyCount>();
                for (int i = 0; i < medicineDemand.Count; i++)
                {
                    MedicineSupplyCount msp = new MedicineSupplyCount();
                    msp.medicineName = medicineDemand[i].medicineName;
                    if (medStock[i].NumberOfTabletsInStock < medicineDemand[i].demandCount)
                    {
                        msp.supplyCount = medStock[i].NumberOfTabletsInStock / pnames.pharmacies.Count;
                    }
                    else
                    {
                        msp.supplyCount = medicineDemand[i].demandCount / pnames.pharmacies.Count;
                    }
                    msplist.Add(msp);
                }
                for (int i = 0; i < pnames.pharmacies.Count; i++)
                {
                    PharmacyMedicineSupply pms = new PharmacyMedicineSupply();
                    pms.pharmacyName = GetListOfPharmacy()[i];
                    pms.medicineSupplyCount = msplist;
                    p.Add(pms);
                }
                return p;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<List<Stock>> GetMedicineStock()
        {
            List<Stock> medicineStock = new List<Stock>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    //Define request data format  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //Sending request to find web api REST service resource MedicineDemand using HttpClient  
                    HttpResponseMessage Res = await client.GetAsync("api/MedicineStocks");
                    if (Res.IsSuccessStatusCode)
                    {
                        var StockResponse = Res.Content.ReadAsStringAsync().Result;
                        medicineStock = JsonConvert.DeserializeObject<List<Stock>>(StockResponse);
                    }

                    return medicineStock;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
