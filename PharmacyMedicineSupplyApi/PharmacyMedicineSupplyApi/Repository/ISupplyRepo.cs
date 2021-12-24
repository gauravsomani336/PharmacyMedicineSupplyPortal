using PharmacyMedicineSupplyApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupplyApi.Repository
{
    public interface ISupplyRepo
    {
        public Task<List<PharmacyMedicineSupply>> GetPharmacySupply(List<MedicineDemand> lisMedDemand);

        public Task<List<Stock>> GetMedicineStock();

        public List<String> GetListOfPharmacy();
    }
}
