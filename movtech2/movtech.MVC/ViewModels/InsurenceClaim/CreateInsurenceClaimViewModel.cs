using movtech.Domain.Contracts.InsurenceClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.InsurenceClaim
{
    public class CreateInsurenceClaimViewModel : CreateInsurenceClaimRequest
    {
        public IEnumerable<Domain.Entities.Insurence> Insurences { get; set; }
    }
}
