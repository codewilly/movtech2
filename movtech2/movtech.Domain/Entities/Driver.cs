using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Driver : Person
    {
        public string CNH { get; set; }

        public string CNHCategory { get; set; }

        public int? VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public DriverStatus Status { get; set; } = DriverStatus.Ativo;

        public Driver(string cNH, string cNHCategory, int? vehicleId, Vehicle vehicle, DriverStatus status, int id, string name, string cPF, DateTime birthDate, string phone, string email, string cEP, string street, int number, string neighborhood, string city, UF uF) :base(id,name,cPF,birthDate,phone,email,cEP,street,number,neighborhood,city,uF)
        {
            CNH = cNH;
            CNHCategory = cNHCategory;
            VehicleId = vehicleId;
            Vehicle = vehicle;
            Status = status;
        }
        public Driver()
        {

        }



        #region Methods

        public string GetInVehicle(Vehicle vehicle)
        {
            if (Vehicle is null)
            {
                if (vehicle.Driver is null)
                {
                    Vehicle = vehicle;
                    vehicle.Driver = this;
                    vehicle.DriverId = Id;

                    string _exitFeedback = Vehicle.ExitGarage();

                    return _exitFeedback;

                }
                else
                {
                    return $"O veículo já está associado o motorista de CPF {vehicle.Driver.CPF}";
                }

            }
            else
            {
                return $"Motorista já associado ao veículo {Vehicle.LicensePlate}";
            }


        }

        public string GetOutVehicle(string placa)
        {
            if (Vehicle != null)
            {
                if (Vehicle.LicensePlate.ToUpper() == placa.ToUpper())
                {
                    string _entranceFeedback = Vehicle.EntranceInGarage();

                    if (_entranceFeedback == "ok")
                    {
                        Vehicle.DriverId = null;
                        Vehicle.Driver = null;
                        Vehicle = null;

                        return "ok";
                    }
                    else
                    {
                        return _entranceFeedback;
                    }

                }
                else
                {
                    return "O veículo informado não está associado a este motorista!";
                }
            }
            else
            {
                return "Nenhum veículo associado.";
            }

        }

        #endregion
    }
}
