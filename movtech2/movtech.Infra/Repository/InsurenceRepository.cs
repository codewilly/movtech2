using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace movtech.Infra.Repository
{
    public class InsurenceRepository : BaseRepository<Insurence>, IInsurenceRepository
    {
        private new readonly MovtechContext _context;

        public InsurenceRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Insurence>> GetAllInsurences()
        {
            var _log = from l in _context.Insurences.Include(p => p.Vehicle).Include(p => p.Broker).Include(p => p.Insurer) select l;
            return await _log.ToListAsync();
            
        }

        public async Task<Insurence> GetInsurence(int id)
        {
            var _log = from l in _context.Insurences.Where(p => p.Id == id).Include(p => p.Vehicle).Include(p => p.Broker).Include(p => p.Insurer) select l;

            return await _log.FirstOrDefaultAsync();
        }
    }
}
