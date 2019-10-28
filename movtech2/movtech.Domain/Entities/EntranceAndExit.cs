using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class EntranceAndExit
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }        

        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public float VehicleKms { get; set; }

        public bool IsEntrance { get; set; }

    }
}
