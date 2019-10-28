using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IEntranceAndExitRepository : IBaseRepository<EntranceAndExit>
    {
        List<EntranceAndExit> GetEntranceAndExitLog(string placa, string cpf, bool asc);
    }
}
