using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProj.Models
{
    public class PharmacyMedicineSupply
    {
        public string pharmacyName { get; set; }

        public List<MedicineSupplyCount> medicineSupplyCount { get; set; }

    }
    public class MedicineSupplyCount
    {
        public string medicineName { get; set; }

        public int supplyCount { get; set; }

    }
}
