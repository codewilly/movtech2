using movtech.Domain.Contracts;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class EntranceAndExitService : BaseService<EntranceAndExit>, IEntranceAndExitService
    {
        private readonly IEntranceAndExitRepository _entranceAndExitRepository;

        public EntranceAndExitService(IEntranceAndExitRepository entranceAndExitRepository) : base(entranceAndExitRepository)
        {
            _entranceAndExitRepository = entranceAndExitRepository;
        }

        public List<AuxModelState> EntranceExitValidation(Vehicle vehicle, Driver driver, float Quilometers, bool IsEntrance)
        {

            var _modelState = new List<AuxModelState>();

            if (vehicle is null)
            {
                _modelState.Add(new AuxModelState()
                {
                    Field = "VehicleId",
                    Message = "Veículo não encontrado"
                });
            }

            if (driver is null)
            {
                _modelState.Add(new AuxModelState()
                {
                    Field = "DriverId",
                    Message = "Motorista não encontrado"
                });
            }

            if (driver != null)
            {
                if (driver.Vehicle != null)
                {
                    if (vehicle.Driver != null)
                    {
                        if (vehicle.Id != driver.Vehicle.Id)
                        {
                            _modelState.Add(new AuxModelState()
                            {
                                Field = "model",
                                Message = "O veículo não está associado ao motorista do CPF informado"
                            });
                        }
                    }
                    else
                    {
                        _modelState.Add(new AuxModelState()
                        {
                            Field = "model",
                            Message = "O veículo não está associado a nenhum motorista"
                        });
                    }

                    if (Quilometers < vehicle.Quilometers)
                    {
                        _modelState.Add(new AuxModelState()
                        {
                            Field = "Quilometers",
                            Message = $"A quilometragem informada ({Quilometers} kms) não pode ser menor que a quilometragem atual ({vehicle.Quilometers} kms) do veículo."
                        });
                    }

                    try
                    {
                        if (IsEntrance)
                        {
                            vehicle.EntranceInGarage();
                        }
                        else
                        {
                            vehicle.ExitGarage();
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        _modelState.Add(new AuxModelState()
                        {
                            Field = "model",
                            Message = ex.Message
                        });
                    }
                }
                else
                {
                    _modelState.Add(new AuxModelState()
                    {
                        Field = "model",
                        Message = "O motorista do CPF informado não está associado a nenhum veículo"
                    });
                }

            }

            return _modelState;
        }

        public List<EntranceAndExit> GetEntranceAndExitLog(string placa, string cpf, bool asc)
        {
            return _entranceAndExitRepository.GetEntranceAndExitLog(placa, cpf, asc);
        }
    }
}
