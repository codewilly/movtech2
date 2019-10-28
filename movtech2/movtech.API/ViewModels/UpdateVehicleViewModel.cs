using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels
{
    public class UpdateVehicleViewModel
    {
        [Required(ErrorMessage = "Informe o nome da marca")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Informe o modelo")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Informe o ano do modelo")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Informe a quilometragem atual")]
        public float Quilometers { get; set; }

        [Required(ErrorMessage = "Informe o tipo de combustível")]
        public FuelType FuelType { get; set; }

        [Required(ErrorMessage = "Informe o tipo de veículo")]
        public VehicleType VehicleType { get; set; }
    }
}
