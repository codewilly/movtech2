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

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(10, 10000, ErrorMessage = "O valor total deve estar entre R${1} e R${2}")]
        public double TotalValue { get; set; }

        public double LiterValue { get; set; }

        public float Liters { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime RefuelDate { get; set; }

        public string VehicleLicensePlate { get; set; }

        public string DriverCPF { get; set; }

        public string GasStationCNPJ { get; set; }



    }
}
