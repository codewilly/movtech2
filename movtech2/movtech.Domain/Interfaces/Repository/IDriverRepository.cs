using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IDriverRepository : IBaseRepository<Driver>
    {
        Driver GetByCPF(string cpf);
    }
}
