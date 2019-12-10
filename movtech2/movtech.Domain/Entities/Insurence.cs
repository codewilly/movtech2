using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Insurence
    {
        public int Id { get; set; }

        public bool HasInsurenceClaim { get; set; }

        public DateTime BeginOfVigency { get; set; }

        public DateTime EndOfVigency { get; set; }

        public int BonusClass { get; set; }
        public string CINumber { get; set; }
        public string PolicyNumber { get; set; }

        public int InsurerId { get; set; }
        public Insurer Insurer { get; set; }

        public int? BrokerId { get; set; }
        public Broker Broker { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

       


    }

}
