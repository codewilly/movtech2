using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.InsurenceClaim
{
    public class CreateInsurenceClaimRequest : AddressRequest
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
