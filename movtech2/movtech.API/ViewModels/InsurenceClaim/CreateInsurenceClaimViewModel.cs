using movtech.API.ViewModels.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.InsurenceClaim
{
    public class CreateInsurenceClaimViewModel : AddressViewModel
    {

        public string DriverCPF { get; set; }
        public int InsurenceId { get; set; }      

        public DateTime InsurenceClaimDate { get; set; }

        public string OccurrenceNumber { get; set; }

        public string Observation { get; set; }

        public string InsurenceClaimNumber { get; set; }

        public InsurenceClaimType InsurenceClaimType { get; set; }
    }
}
