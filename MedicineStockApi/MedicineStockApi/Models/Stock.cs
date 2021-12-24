using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockApi.Models
{
    public class Stock
    {
        [Key]
        public string name { get; set; }

        public string ChemicalComposition { get; set; }

        public string TargetAilment { get; set; }

        public DateTime DateOfExpiry { get; set; }

        public int NumberOfTabletsInStock { get; set; }

        Stock() { }
        Stock(string name, string chemicalComposition, string TargetAilment, DateTime DateOfExpiry,int count)
        {
            this.name = name;
            this.ChemicalComposition = chemicalComposition;
            this.TargetAilment = TargetAilment;
            this.DateOfExpiry = DateOfExpiry;
            this.NumberOfTabletsInStock = count;
        }
    }
}
