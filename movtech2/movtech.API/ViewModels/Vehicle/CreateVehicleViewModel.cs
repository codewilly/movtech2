using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Vehicle
{
    public class CreateVehicleViewModel
    {

        [Required(ErrorMessage = "Informe o nome da marca")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Informe o modelo")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Informe a placa")]
        [RegularExpression(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "A placa deve seguir o padrão: AAA-0000")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Informe o RENAVAM")]
        [StringLength(11, ErrorMessage = "Deve conter {0} caracteres!")]
        public string Renavam { get; set; }

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
