using movtech.Domain.Contracts;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Services
{
    public interface IEntranceAndExitService : IBaseService<EntranceAndExit>
    {

        List<AuxModelState> EntranceExitValidation(Vehicle vehicle, Driver driver, float Quilometers, bool IsEntrance);

        List<EntranceAndExit> GetEntranceAndExitLog(string placa, string cpf, bool asc);
    }
}
