﻿using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.Repository
{
    public class MaintenanceRepository : BaseRepository<Maintenance>, IMaintenanceRepository
    {
        private new readonly MovtechContext _context;

        public MaintenanceRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }
    }
}