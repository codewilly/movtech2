using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Insurence
{
    public class CreateInsurenceViewModel
    {
      
        
        public DateTime BeginOfVigency { get; set; }

        public DateTime EndOfVigency { get; set; }

        public int BonusClass { get; set; }
        public string CINumber { get; set; }
        public string PolicyNumber { get; set; }

        public int InsurerId { get; set; }

        public int BrokerId { get; set; }
        public int VehicleId { get; set; }
    }
}
