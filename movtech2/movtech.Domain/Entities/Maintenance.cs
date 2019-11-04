using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }

        public DateTime MaintenanceDate { get; set; }

        public MaintenanceType MaintenanceType { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public decimal Cost { get; set; }

        public bool PreventivaOrCorretiva { get; set; }

        public bool TiresChanged { get; set; }

        public bool OilChanged { get; set; }

        public string OperationDescription { get; set; }
        public Maintenance()
        {

        }
        public Maintenance(DateTime maintenanceDate, MaintenanceType maintenanceType, int vehicleId, Vehicle vehicle, decimal cost, bool preventivaOrCorretiva, bool tiresChanged, bool oilChanged, string operationDescription)
        {
            MaintenanceDate = maintenanceDate;
            MaintenanceType = maintenanceType;
            VehicleId = vehicleId;
            Vehicle = vehicle;
            Cost = cost;
            PreventivaOrCorretiva = preventivaOrCorretiva;
            TiresChanged = tiresChanged;
            OilChanged = oilChanged;
            OperationDescription = operationDescription;
        }

        public void DoMaintenance()
        {

            if (Vehicle != null)
            {

                if (OilChanged)
                {
                    Vehicle.OilChange();
                }

                if (TiresChanged)
                {
                    Vehicle.TiresChange();
                }

                if (PreventivaOrCorretiva)
                {
                    Vehicle.Maintenance();
                }

            }
            else
            {
                throw new NullReferenceException("Nenhum veículo está associado a esta manutenção!");
            }
        }


    }
}
