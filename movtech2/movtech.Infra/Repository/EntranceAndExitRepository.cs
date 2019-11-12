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
    public class EntranceAndExitRepository : BaseRepository<EntranceAndExit>, IEntranceAndExitRepository
    {
        private new readonly MovtechContext _context;

        public EntranceAndExitRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<EntranceAndExit>> GetEntranceAndExitLog(string placa, string cpf, bool asc)
        {

            var _log = from l in _context.EntranceAndExits.Include(p => p.Vehicle).ThenInclude(p => p.Driver) select l;

            if (!string.IsNullOrEmpty(placa))
            {
                _log = _log.Where(x => x.Vehicle.LicensePlate == placa);
            }

            if (!string.IsNullOrEmpty(cpf))
            {
                _log = _log.Where(x => x.Driver.CPF == cpf);
            }

            _log = asc ? _log.OrderBy(x => x.Id) : _log.OrderByDescending(x => x.Id);

            return await _log.ToListAsync();

        }
    }
}
