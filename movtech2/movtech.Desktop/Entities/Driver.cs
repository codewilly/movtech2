using movtech.Desktop.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Desktop.Entities
{
    public class Driver 
    {
        public string CNH { get; set; }

        public string CNHCategory { get; set; }

        public int? VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public DriverStatus Status { get; set; } = DriverStatus.Ativo;
                     
       
    }
}
