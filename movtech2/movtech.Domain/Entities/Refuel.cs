using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Refuel
    {
        public int Id { get; set; }

        public double TotalValue { get; set; }

        public double LiterValue { get; set; }

        public float Liters { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime RefuelDate { get; set; }

        public Vehicle Vehicle { get; set; }

        public GasStation GasStation { get; set; }
    }
}
