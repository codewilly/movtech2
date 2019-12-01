using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.Maintenance
{
    public class RegisterMaintenanceRequest
    {
        public string LicensePlate { get; set; }

        public decimal Cost { get; set; }

        public bool PreventivaOrCorretiva { get; set; }

        public bool TiresChanged { get; set; }

        public bool OilChanged { get; set; }

        public string OperationDescription { get; set; }
    }
}
