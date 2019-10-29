using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.Repository
{
    public class RefuelRepository : BaseRepository<Refuel>, IRefuelRepository
    {
        private new readonly MovtechContext _context;

        public RefuelRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }
    }
}
