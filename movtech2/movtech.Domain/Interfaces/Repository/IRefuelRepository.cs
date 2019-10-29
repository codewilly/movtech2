using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IRefuelRepository : IBaseRepository<Refuel>
    {
        Task<List<Refuel>> GetRefuelLog(string placa, string cpf, string cnpj, bool asc);
    }
}
