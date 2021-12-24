using WebProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProj.Repository
{
    public interface IPharmacySupplyPortal
    {
        Task<List<MedicineDemand>> GetMedicineDemand();

        Task<List<PharmacyMedicineSupply>> GetSupplies(List<MedicineDemand> medicineDemand);
    }
}
