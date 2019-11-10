using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.ViewModels.Vehicle
{
    public class DetailsVehicleViewModel
    {
        public Domain.Entities.Vehicle Vehicle { get; set; }

        public int PercentMaintenance { get; set; }

        public string PercentMaintenanceClass { get; set; }

        public int PercentOil { get; set; }

        public string PercentOilClass { get; set; }

        public int PercentTires { get; set; }

        public string PercentTiresClass { get; set; }

        



    }
}
