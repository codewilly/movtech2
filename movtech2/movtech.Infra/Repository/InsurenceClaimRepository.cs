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
    public class InsurenceClaimRepository : BaseRepository<InsurenceClaim> , IInsurenceClaimRepository
    {

        private new readonly MovtechContext _context;

        public InsurenceClaimRepository(MovtechContext context) : base(context)
        {
            _context = context;
        }

        public new IEnumerable<InsurenceClaim> GetAll()
        {
            return _context.InsurenceClaims.Include(p => p.Driver).Include(p => p.Insurence).ThenInclude(p => p.Vehicle);
        }
        public new InsurenceClaim Get(int id)
        {
            return _context.InsurenceClaims.Where(p => p.Id == id).Include(p => p.Driver).Include(p => p.Insurence).ThenInclude(p => p.Vehicle).FirstOrDefault();
            
        }

    }
}
