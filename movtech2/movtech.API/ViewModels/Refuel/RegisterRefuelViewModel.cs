using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Refuel
{
    public class RegisterRefuelViewModel
    {

        public decimal TotalValue { get; set; }

        public decimal LiterValue { get; set; }

        public float Liters { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime RefuelDate { get; set; }

        public string VehicleLicensePlate { get; set; }

        public string DriverCPF { get; set; }

        public string GasStationCNPJ { get; set; }


    }
}
