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

        public string Description { get; set; }


        public override string ToString()
        {

            var _entrouSaiu = IsEntrance ? "entrou na" : "saiu da";

            return $"{Driver.Name} {_entrouSaiu} garagem com o veículo de placa {Vehicle.LicensePlate} em {CreationDate}";

        }
        public EntranceAndExit()
        {

        }
       

        public EntranceAndExit( DateTime creationDate, int vehicleId, Vehicle vehicle, int driverId, Driver driver, float vehicleKms, bool isEntrance, string description)
        {
            
            CreationDate = creationDate;
            VehicleId = vehicleId;
            Vehicle = vehicle;
            DriverId = driverId;
            Driver = driver;
            VehicleKms = vehicleKms;
            IsEntrance = isEntrance;
            Description = description;
        }
    }
}
