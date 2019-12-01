using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.Maintenance
{
    public class RegisterMaintenanceViewModel
    {

        public int VehicleId { get; set; }
        
        public decimal Cost { get; set; }

        public bool PreventivaOrCorretiva { get; set; }

        public bool TiresChanged { get; set; }

        public bool OilChanged { get; set; }

        public string OperationDescription { get; set; }

    }
}
