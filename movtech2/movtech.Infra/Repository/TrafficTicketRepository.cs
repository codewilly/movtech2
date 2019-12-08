using Microsoft.EntityFrameworkCore;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Infra.Repository
{
    public class TrafficTicketRepository : BaseRepository<TrafficTicket>, ITrafficTicketRepository
    {
        private new readonly MovtechContext _context;

        public TrafficTicketRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<TrafficTicket>> GetTrafficTickets(string cpf, string placa)
        {
            var _log = from l in _context.TrafficTickets
                       .Include(x => x.Vehicle)
                       .Include(x => x.Driver)
                       select l;

            if (!string.IsNullOrEmpty(placa))
            {
                _log = _log.Where(x => x.Vehicle.LicensePlate == placa);
            }

            if (!string.IsNullOrEmpty(cpf))
            {
                _log = _log.Where(x => x.Driver.CPF == cpf);
            }



            return await _log.ToListAsync();
        }
        public async Task<TrafficTicket> GetTrafficTicket(int id)
        {
             return await _context.TrafficTickets.Where(d => d.Id == id).Include(p => p.Driver).ThenInclude(v => v.Vehicle).FirstOrDefaultAsync();

           
        }
    }
}
