using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IInsurenceRepository : IBaseRepository<Insurence>
    {



        Task<IEnumerable<Insurence>> GetAllInsurences();
        Task<Insurence> GetInsurence(int id);

    }
}
