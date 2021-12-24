using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupplyApi.Model
{
    public class Stock
    {
        public string name { get; set; }

        public string ChemicalComposition { get; set; }

        public string TargetAilment { get; set; }

        public DateTime DateOfExpiry { get; set; }

        public int NumberOfTabletsInStock { get; set; }

        
    }
}
