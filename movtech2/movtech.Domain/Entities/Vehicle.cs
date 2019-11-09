using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        private string _licensePlate { get; set; }
        public string LicensePlate
        {
            get => _licensePlate;
            set => _licensePlate = value.ToUpper();
        }

        public string Renavam { get; set; }

        private int _year { get; set; }

        public int Year
        {
            get => _year;
            set => _year = SetYear(value);
        }

        private float _quilometers { get; set; }

        public float Quilometers
        {
            get => _quilometers;
            set => _quilometers = SetQuilometers(value);
        }


        public FuelType FuelType { get; set; }

        public VehicleType VehicleType { get; set; }

        public bool InGarage { get; set; } = true;

        public VehicleStatus Status { get; set; } = VehicleStatus.Disponivel;

        public Driver Driver { get; set; }

        public int? DriverId { get; set; }

        // Maintenance

        public List<Maintenance> Maintenances { get; set; }

        public DateTime LastMaintenanceDate { get; set; }

        public float LastMaintenanceKms { get; set; }

        public float LastTireChangeKms { get; set; }

        public float LastOilChangeKms { get; set; }

        public bool NeedsMaintenance { get; set; }

        public bool NeedsChangeTires { get; set; }

        public bool NeedsChangeOil { get; set; }


        #region Contructor

        protected Vehicle() { } // EF Ctor

        public Vehicle(int year)
        {
            _year = SetYear(year);
        }

        public Vehicle(string brand, string model, string licensePlate, string renavam, int year, float quilometers, FuelType fuelType, VehicleType vehicleType, bool inGarage, VehicleStatus status, Driver driver, int? driverId, DateTime lastMaintenanceDate, float lastMaintenanceKms, float lastTireChangeKms, float lastOilChangeKms)
        {
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            Renavam = renavam;
            Year = year;
            Quilometers = quilometers;
            FuelType = fuelType;
            VehicleType = vehicleType;
            InGarage = inGarage;
            Status = status;
            Driver = driver;
            DriverId = driverId;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceKms = lastMaintenanceKms;
            LastTireChangeKms = lastTireChangeKms;
            LastOilChangeKms = lastOilChangeKms;

        }

        #endregion

        #region Methods

        public int SetYear(int year)
        {
            int _maxYear = DateTime.Now.Year + 1;
            return (year > 1990 && year < _maxYear) ? year : throw new ArgumentOutOfRangeException($"O ano deve estar entre 1990 e {_maxYear}");
        }

        private float SetQuilometers(float kms)
        {
            if (kms < Quilometers)
            {
                throw new ArgumentException("A nova quilometragem deve ser maior ou igual a quilometragem atual!");
            }

            return kms;
        }

        public char NeedsCNHType()
        {
            switch (VehicleType)
            {
                case VehicleType.Moto:
                    return 'A';

                case VehicleType.Carro:
                    return 'B';

                case VehicleType.Caminhao:
                    return 'D';

                default:
                    throw new Exception("Tipo não reconhecido");
            }
        }

        public string EntranceInGarage()
        {
            if (InGarage)
            {
                return ($"{LicensePlate} já está na garagem.");
            }
            else
            {
                InGarage = true;
                return "ok";
            }
        }

        public string ExitGarage()
        {
            if (!InGarage)
            {
                return ($"{LicensePlate} já está fora da garagem!");
            }
            else
            {
                InGarage = false;
                return "ok";
            }
        }

        // Maintenance

        public void CheckMaintenance()
        {

            // 0 Carro, 1 Moto, 2 Caminhao
            int[] _maintenanceDays = { 180, 120, 360 };
            float[] _maintenanceKms = { 10000, 2000, 15000 };

            float[] _oilKms = { 5000, 1000, 10000 };

            float[] _tireKms = { 70000, 70000, 70000 };

            var _maintenanceDateDiff = DateTime.Now - LastMaintenanceDate;

            int _vehicleType = (int)VehicleType - 1;

            // Manutenção preventiva
            if (LastMaintenanceKms + _maintenanceKms[_vehicleType] <= Quilometers ||
                _maintenanceDateDiff.Days >= _maintenanceDays[_vehicleType])
            {
                NeedsMaintenance = true;
            }

            // Troca de óleo
            if (LastOilChangeKms + _oilKms[_vehicleType] <= Quilometers)
            {
                NeedsChangeOil = true;
            }

            // Troca de pneu
            if (LastTireChangeKms + _tireKms[_vehicleType] <= Quilometers)
            {
                NeedsChangeTires = true;
            }

        }

        public List<string> GetMaintenanceList()
        {
            var MaintenanceList = new List<string>();

            if (NeedsMaintenance)
            {
                MaintenanceList.Add("Manutenção preventiva necessária!");
            }

            if (NeedsChangeOil)
            {
                MaintenanceList.Add("Troca de óleo necessária!");
            }

            if (NeedsChangeTires)
            {
                MaintenanceList.Add("Troca de pneus necessária!");
            }

            return MaintenanceList;

        }

        public void Maintenance()
        {
            LastMaintenanceDate = DateTime.Now;
            LastMaintenanceKms = Quilometers;
            NeedsMaintenance = false;
        }

        public void OilChange()
        {
            LastOilChangeKms = Quilometers;
            NeedsChangeOil = false;
        }

        public void TiresChange()
        {
            LastTireChangeKms = Quilometers;
            NeedsChangeTires = false;
        }



        #endregion


    }
}
