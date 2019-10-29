using movtech.API.ViewModels.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.TrafficTicket
{
    public class RegisterTrafficTicketViewModel : AddressViewModel
    {

        public string VehicleLicensePlate { get; set; }

        public string DriverCPF { get; set; }

        public DateTime TrafficTicketDate { get; set; }

        public DateTime BilletExpiration { get; set; }

        public decimal Cost { get; set; }

        public int Points { get; set; }

        public TrafficTickeLevel Level { get; set; }

        public string Description { get; set; }


    }
}
