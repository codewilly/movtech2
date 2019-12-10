using movtech.API.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Insurer
{
    public class CreateInsurerViewModel : AddressViewModel
    {
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }
}
