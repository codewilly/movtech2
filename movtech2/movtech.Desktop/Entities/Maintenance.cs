using movtech.Desktop.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Desktop.Entities
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
