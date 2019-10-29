using movtech.Domain.Contracts;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Services
{
    public interface IEntranceAndExitService : IBaseService<EntranceAndExit>
    {

        List<AuxModelState> EntranceExitValidation(Vehicle vehicle, Driver driver, float Quilometers, bool IsEntrance);

        Task<List<EntranceAndExit>> GetEntranceAndExitLog(string placa, string cpf, bool asc);


        EntranceAndExit Register(Vehicle vehicle, Driver driver, float kms, bool isEntrance);



    }
}
