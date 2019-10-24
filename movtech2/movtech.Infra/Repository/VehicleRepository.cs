using Microsoft.EntityFrameworkCore;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.Repository
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        private new readonly MovtechContext _context;

        public VehicleRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

    }
}
