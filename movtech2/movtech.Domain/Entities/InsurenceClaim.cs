using movtech.Domain.Entities.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class InsurenceClaim : Address
    {
        public int Id { get; set; }



        public int InsurenceId { get; set; }
        public Insurence Insurence { get; set; }


        public DateTime InsurenceClaimDate { get; set; }

        public string OccurrenceNumber { get; set; }

        public string Observation { get; set; }

        public string InsurenceClaimNumber { get; set; }

        public InsurenceClaimType InsurenceClaimType { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }


    }
}
