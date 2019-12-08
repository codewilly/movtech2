using Microsoft.AspNetCore.Mvc.Rendering;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.Refuel
{
    public class RefuelIndexViewModel
    {

        public List<SelectListItem> Postos { get; set; } = new List<SelectListItem>();

        [Required(ErrorMessage = "Informe a placa")]
        [RegularExpression(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "A placa deve seguir o padrão: AAA-0000")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Informe um CPF no formato  000.000.000-00")]
        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public decimal TotalValue { get; set; }

        public decimal LiterValue { get; set; }

        public float Liters { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime RefuelDate { get; set; }
    }
}
