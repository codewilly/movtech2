using movtech.Domain.Contracts;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Services
{
    public class EntranceAndExitService : BaseService<EntranceAndExit>, IEntranceAndExitService
    {
        private List<AuxModelState> ModelStateErrors;

        private readonly IEntranceAndExitRepository _entranceAndExitRepository;

        public EntranceAndExitService(IEntranceAndExitRepository entranceAndExitRepository) : base(entranceAndExitRepository)
        {
            _entranceAndExitRepository = entranceAndExitRepository;
        }

        private void AddModelStateError(string field, string message)
        {
            ModelStateErrors.Add(new AuxModelState()
            {
                Field = field,
                Message = message
            });
        }

        public List<AuxModelState> EntranceExitValidation(Vehicle vehicle, Driver driver, float Quilometers, bool IsEntrance)
        {
            ModelStateErrors = new List<AuxModelState>();

            if (vehicle is null)
            {
                AddModelStateError("VehicleId", "Veículo não encontrado");
            }

            if (driver is null)
            {
                AddModelStateError("DriverId", "Motorista não encontrado");
            }

            if (driver != null && vehicle != null)
            {

                if (Quilometers < vehicle.Quilometers)
                {
                    AddModelStateError("Quilometers", $"A quilometragem informada ({Quilometers} kms) não pode ser menor que a quilometragem atual ({vehicle.Quilometers} kms) do veículo.");
                }

                string _inOrOutFeedback = IsEntrance ? driver.GetOutVehicle(vehicle.LicensePlate) : driver.GetInVehicle(vehicle);

                if (_inOrOutFeedback != "ok")
                {
                    AddModelStateError("model", _inOrOutFeedback);
                }

            }

            return ModelStateErrors;
        }

        public Task<List<EntranceAndExit>> GetEntranceAndExitLog(string placa, string cpf, bool asc)
        {
            return _entranceAndExitRepository.GetEntranceAndExitLog(placa, cpf, asc);
        }

        public EntranceAndExit Register(Vehicle vehicle, Driver driver, float kms, bool isEntrance)
        {
            vehicle.Quilometers = kms;
            vehicle.CheckMaintenance();

            var _exit = new EntranceAndExit()
            {
                CreationDate = DateTime.Now,
                Driver = driver,
                Vehicle = vehicle,
                VehicleKms = kms,
                IsEntrance = isEntrance,
            };


            _exit.Description = _exit.ToString();

            return Insert(_exit);

        }
    }
}
