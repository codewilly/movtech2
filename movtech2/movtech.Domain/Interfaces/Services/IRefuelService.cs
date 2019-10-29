using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Services
{
    public interface IRefuelService : IBaseService<Refuel>
    {
        Task<List<Refuel>> GetRefuelLog(string placa, string cpf, string cnpj, bool asc);
    }
}
