using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movtech.Infra.Repository
{
    public class GasStationRepository : BaseRepository<GasStation>, IGasStationRepository
    {
        private new readonly MovtechContext _context;

        public GasStationRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public GasStation GetByCnpj(string cnpj)
        {
            return _context.GasStations.Where(d => d.CNPJ == cnpj).FirstOrDefault();
        }
    }
}
