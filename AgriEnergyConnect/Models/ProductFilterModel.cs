using System;
using System.Collections.Generic;

namespace AgriEnergyConnect.Models
{
    public class ProductFilterViewModel
    {
        // Filter Criteria
        public string? Category { get; set; }
        public string? FarmerName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Results
        public List<Product> Products { get; set; } = new();
    }
}
