using movtech.Domain.Contracts.Insurence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.Insurence
{
    public class InsurenceCreateViewModel : CreateInsurenceRequest
    {
        public IEnumerable<movtech.Domain.Entities.Insurer> Insurers { get; set; }

        public IEnumerable<movtech.Domain.Entities.Broker> Brokers { get; set; }
        public IEnumerable<movtech.Domain.Entities.Vehicle> Vehicles { get; set; }
    }
}
