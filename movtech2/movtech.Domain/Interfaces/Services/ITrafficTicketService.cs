using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Services
{
    public interface ITrafficTicketService : IBaseService<TrafficTicket>
    {
        Task<List<TrafficTicket>> GetTrafficTickets(string cpf, string placa);

    }
}
