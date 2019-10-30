﻿using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class TrafficTicketService : BaseService<TrafficTicket>, ITrafficTicketService
    {
        private readonly ITrafficTicketRepository _trafficTicketRepository;

        public TrafficTicketService(ITrafficTicketRepository trafficTicketRepository) : base(trafficTicketRepository)
        {
            _trafficTicketRepository = trafficTicketRepository;
        }

    }
}