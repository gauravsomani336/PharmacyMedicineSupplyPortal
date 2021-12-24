using WebProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebProj.Helper;
using WebProj.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WebProj.Controllers
{
    
    public class HomeController : Controller
    {
        private ISchedule _Ischedule;
        private IPharmacySupplyPortal _pharmacySupplyPortal;
        private string Token { get => HttpContext.Session.GetString("token"); }
        public HomeController(ISchedule schedule, IPharmacySupplyPortal pharmacySupplyPortal)
        {
            _Ischedule = schedule;
            _pharmacySupplyPortal = pharmacySupplyPortal;

        }

        getlist _h = new getlist();

        [AllowAnonymous]
        public IActionResult Index()
        {

            return View();

        }

        [HttpGet]
       
        public async Task<IActionResult> GetStockData()
        {
            if (Token != null)
            {
                List<Stock> s = new List<Stock>();
                HttpClient client = _h.Initial();
                HttpResponseMessage res = await client.GetAsync("api/MedicineStocks");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    s = JsonConvert.DeserializeObject<List<Stock>>(result);

                }
                return View(s);
            }
            else
            {
                TempData["Message"] = "Either you are not Logged in or Session got expired. Please Log in Again";

                return RedirectToAction("Login", "Login");
            }

        }
        [HttpGet]
       public async Task<IActionResult> GetSchedule()
        {
            if (Token != null)
            {
                DatePicker sdate = new DatePicker { date = DateTime.Now };
                return View("GetSchedule", sdate);

            }
            else
            {
                TempData["Message"] = "Either you are not Logged in or Session got expired. Please Log in Again";

                return RedirectToAction("Login", "Login");
            }
        }
    [HttpPost]
        public async Task<IActionResult> GetRepSchedule(DatePicker sdate)
        {
            var schedule = await _Ischedule.CreateSchedule(sdate.date);
            if (schedule.Count != 0 && schedule != null)
            {

                return View("GetRepSchedule", schedule);
            }
            else
            {

                return BadRequest();
            }


        }
        [HttpGet]
        public async Task<IActionResult> GetPharmacySupply()
        {
            if (Token != null)
            {
                List<MedicineDemand> medicineDemand = await _pharmacySupplyPortal.GetMedicineDemand();

                if (medicineDemand == null)
                {
                    return View("Error");
                }

                return View(medicineDemand);
            }
            else
            {
                TempData["Message"] = "Either you are not Logged in or Session got expired. Please Log in Again";

                return RedirectToAction("Login", "Login");
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostPharmacySupply(List<MedicineDemand> medicineDemand)
        {
            if (medicineDemand.Count != 0 && medicineDemand != null)
            {
                List<PharmacyMedicineSupply> supplies = await _pharmacySupplyPortal.GetSupplies(medicineDemand);

                if (supplies != null && supplies.Count != 0)
                {
                    return View("PostPharmacySupply", supplies);
                }
                else
                {
                    return View("Error");
                }
            }
            else
            {
                return View("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        /* public IActionResult Error()
         {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }*/
    }
}

