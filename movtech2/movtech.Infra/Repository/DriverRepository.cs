using Microsoft.EntityFrameworkCore;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movtech.Infra.Repository
{
    public class DriverRepository : BaseRepository<Driver>, IDriverRepository
    {
        private new readonly MovtechContext _context;

        public DriverRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public new Driver Get(int id)
        {
            return _context.Drivers.Where(d => d.Id == id).Include(v => v.Vehicle).FirstOrDefault();
        }

        public new IEnumerable<Driver> GetAll()
        {
            return _context.Drivers.Include(v => v.Vehicle);
        }

        public Driver GetByCPF(string cpf)
        {
            return _context.Drivers.Where(d => d.CPF == cpf).Include(v => v.Vehicle).FirstOrDefault();
        }
    }
}
