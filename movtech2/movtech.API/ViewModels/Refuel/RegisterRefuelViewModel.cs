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

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(10, 100, ErrorMessage = "O valor total deve estar entre R${1} e R${2}")]
        public double LiterValue { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(10, 500, ErrorMessage = "O valor total deve estar entre R${1} e R${2}")]
        public float Liters { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public FuelType FuelType { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime RefuelDate { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "A placa deve seguir o padrão: AAA-0000")]
        public string VehicleLicensePlate { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Informe um CPF no formato  000.000.000-00")]
        public string DriverCPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Informe um CNPJ no formato 00.000.000/0000-00")]
        public string GasStationCNPJ { get; set; }



    }
}
