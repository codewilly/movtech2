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
    public class RefuelRepository : BaseRepository<Refuel>, IRefuelRepository
    {
        private new readonly MovtechContext _context;

        public RefuelRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public new Refuel Get(int id)
        {
            return _context.Refuels.Where(d => d.Id == id)
                .Include(v => v.Vehicle)
                .Include(d => d.Driver)
                .Include(g => g.GasStation)
                .FirstOrDefault();
        }

        public async Task<List<Refuel>> GetRefuelLog(string placa, string cpf, string cnpj, bool asc)
        {
            var _log = from r in _context.Refuels
                                .Include(v => v.Vehicle)
                                .Include(d => d.Driver)
                                .Include(g => g.GasStation)
                                select r;

            if (!string.IsNullOrEmpty(placa))
            {
                _log = _log.Where(x => x.Vehicle.LicensePlate == placa);
            }

            if (!string.IsNullOrEmpty(cpf))
            {
                _log = _log.Where(x => x.Driver.CPF == cpf);
            }

            if (!string.IsNullOrEmpty(cnpj))
            {
                _log = _log.Where(x => x.GasStation.CNPJ == cnpj);
            }

            _log = asc ? _log.OrderBy(x => x.Id) : _log.OrderByDescending(x => x.Id);

            return await _log.ToListAsync();
        }
    }
}
