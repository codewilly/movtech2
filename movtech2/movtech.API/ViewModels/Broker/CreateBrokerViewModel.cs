using movtech.API.ViewModels.Abstract;
using movtech.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Broker
{
    public class CreateBrokerViewModel : AddressViewModel
    {
        
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ResponsibleBroker { get; set; }

    }
}
