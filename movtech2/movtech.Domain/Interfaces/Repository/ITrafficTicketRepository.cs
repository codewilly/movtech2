using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Repository
{
    public interface ITrafficTicketRepository : IBaseRepository<TrafficTicket>
    {
        Task<List<TrafficTicket>> GetTrafficTickets(string cpf, string placa);
        Task<TrafficTicket> GetTrafficTicket(int id);
    }
}
