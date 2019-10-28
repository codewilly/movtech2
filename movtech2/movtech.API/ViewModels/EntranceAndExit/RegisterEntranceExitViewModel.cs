﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.EntranceAndExit
{
    public class RegisterEntranceExitViewModel
    {

        [Required(ErrorMessage = "Informe a placa")]
        [RegularExpression(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "A placa deve seguir o padrão: AAA-0000")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Informe o CPF do motorista")]
        public string DriverCPF { get; set; }

        [Required(ErrorMessage = "Informe a quilometragem atual do veículo")]
        public float Quilometers { get; set; }


    }
}
