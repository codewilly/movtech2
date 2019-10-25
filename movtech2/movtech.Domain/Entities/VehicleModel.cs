using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class VehicleModel
    {
        public int Id { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleBrand VehicleBrand { get; set; }

        public string Name { get; set; }    

    }
}
