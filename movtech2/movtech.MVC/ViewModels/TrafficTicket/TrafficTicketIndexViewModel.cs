using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.TrafficTicket
{
    public class TrafficTicketIndexViewModel
    {
        public Domain.Entities.TrafficTicket TrafficTicket { get; set; }
        public Domain.Entities.Vehicle Vehicle { get; set; }
        public Domain.Entities.Driver Driver { get; set; }
        


    }
}
