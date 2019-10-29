using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IEntranceAndExitRepository : IBaseRepository<EntranceAndExit>
    {
        Task<List<EntranceAndExit>> GetEntranceAndExitLog(string placa, string cpf, bool asc);
    }
}
