﻿using Microsoft.EntityFrameworkCore;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public new Vehicle Get(int id)
        {
            return _context.Vehicles.Where(d => d.Id == id).Include(v => v.Driver).FirstOrDefault();
        }

        public new IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles.Include(v => v.Driver);
        }

        public Vehicle GetByLicensePlate(string lp)
        {
            return _context.Vehicles.Where(d => d.LicensePlate == lp).Include(v => v.Driver).FirstOrDefault();
        }
    }
}
