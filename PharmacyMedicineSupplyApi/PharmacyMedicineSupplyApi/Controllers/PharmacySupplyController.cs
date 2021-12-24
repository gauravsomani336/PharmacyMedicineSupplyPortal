using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;
using PharmacyMedicineSupplyApi.Model;
using Newtonsoft.Json;
using System.Linq;
using PharmacyMedicineSupplyApi.Repository;

namespace PharmacyMedicineSupplyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacySupplyController : ControllerBase
    {
        private readonly ISupplyRepo _supplyRepo;

        public PharmacySupplyController(ISupplyRepo supplyRepo)
        {
            _supplyRepo = supplyRepo;
        }

        [HttpPost]
        public async Task<ActionResult<List<PharmacyMedicineSupply>>> PharmacysupplyGet([FromBody] List<MedicineDemand> medicineDemand)
        {
            List<PharmacyMedicineSupply> pharmacySupply = await _supplyRepo.GetPharmacySupply(medicineDemand);
            
            return pharmacySupply;
        }
    }
}