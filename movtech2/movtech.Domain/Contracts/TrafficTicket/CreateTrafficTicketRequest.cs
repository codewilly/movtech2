using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace movtech.Domain.Contracts.TrafficTicket
{
    public class CreateTrafficTicketRequest : AddressRequest
    {
        [Required(ErrorMessage = "Informe a placa")]
        [RegularExpression(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "A placa deve seguir o padrão: AAA-0000")]
        public string VehicleLicensePlate { get; set; }

        [Required(ErrorMessage = "Informe o CPF do infrator")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Informe um CPF no formato  000.000.000-00")]
        public string DriverCPF { get; set; }

        [Required(ErrorMessage = "Informe a data da multa")]
        public DateTime TrafficTicketDate { get; set; }

        [Required(ErrorMessage = "Informe a data do vencimento do boleto")]
        public DateTime BilletExpiration { get; set; }

        [Required(ErrorMessage = "Informe o valor da multa")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Informe a gravidade da multa")]
        public TrafficTickeLevel Level { get; set; }

        [Required(ErrorMessage = "Informe a descrição da multa")]
        public string Description { get; set; }
    }
}
