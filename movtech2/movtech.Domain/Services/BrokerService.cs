using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    
    public class BrokerService : BaseService<Broker>, IBrokerService
    {
        private readonly IBrokerRepository _brokerRepository;

        public BrokerService(IBrokerRepository brokerRepository) : base(brokerRepository)
        {
            _brokerRepository = brokerRepository;
        }

        
    }
}
