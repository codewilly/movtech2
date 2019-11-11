using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace movtech.Domain.Contracts.EntranceAndExit
{
    public class RegisterExitRequest
    {
        [Required(ErrorMessage = "Informe a placa")]
        [RegularExpression(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "A placa deve seguir o padrão: AAA-0000")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Informe o CPF do motorista")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Informe um CPF no formato  000.000.000-00")]
        public string DriverCPF { get; set; }

    }
}
