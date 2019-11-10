using movtech.Domain.Contracts.ViaCEP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.Services.Interface
{
    public interface IViaCepService
    {
        Task<SearchCepResponse> SearchCep(string cep);
    }

    
}
