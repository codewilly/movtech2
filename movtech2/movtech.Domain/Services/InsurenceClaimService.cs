using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class InsurenceClaimService : BaseService<InsurenceClaim> ,IInsurenceClaimService
    {

        private readonly IInsurenceClaimRepository _insurenceClaimRepository;

        public InsurenceClaimService(IInsurenceClaimRepository insurenceClaimRepository) : base(insurenceClaimRepository)
        {
            _insurenceClaimRepository = insurenceClaimRepository;
        }
    }
}
