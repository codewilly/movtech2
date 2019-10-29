using movtech.API.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Refuel
{
    public class UpdateGasStationViewModel : AddressViewModel
    {
               
        [Required(ErrorMessage = "Nome obrigatório")]
        [MaxLength(150, ErrorMessage = "Deve conter no máximo {1} caracteres")]
        public string Name { get; set; }

    }
}
