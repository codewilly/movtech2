using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movtech.Infra.Repository
{
    public class EntranceAndExitRepository : BaseRepository<EntranceAndExit>, IEntranceAndExitRepository
    {
        private new readonly MovtechContext _context;

        public EntranceAndExitRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public List<EntranceAndExit> GetEntranceAndExitLog(string placa, string cpf, bool asc)
        {

            List<EntranceAndExit> _logs = _context.EntranceAndExits.ToList();


            if (placa != "")
            {
                _logs = _logs.Where(x => x.Vehicle.LicensePlate == placa).ToList();
            }

            return _logs;
        }
    }
}
