using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.Broker
{
    public class UpdateBrokerRequest : AddressRequest
    {
        
        public string Phone { get; set; }
       
        public string Name { get; set; }
       
        public string Email { get; set; }
       
        public string ResponsibleBroker { get; set; }
    }
}
