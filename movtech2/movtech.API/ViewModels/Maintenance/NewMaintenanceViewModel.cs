using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Maintenance
{
    public class NewMaintenanceViewModel
    {

        public string LicensePlate { get; set; }

        public decimal Cost { get; set; }

        public bool PreventivaOrCorretiva { get; set; }

        public bool TiresChanged { get; set; }

        public bool OilChanged { get; set; }

        public string OperationDescription { get; set; }

    }
}
