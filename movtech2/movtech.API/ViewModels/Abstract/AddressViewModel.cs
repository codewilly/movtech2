using movtech.Domain.Entities.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.ViewModels.Abstract
{
    public abstract class AddressViewModel
    {
        [Required(ErrorMessage = "Preencha este campo!")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Deve conter {1} caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [MaxLength(100, ErrorMessage = "Deve conter no máximo {1} caracteres")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [MaxLength(100, ErrorMessage = "Deve conter no máximo {1} caracteres")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [MaxLength(100, ErrorMessage = "Deve conter no máximo {1} caracteres")]
        public string City { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public UF UF { get; set; }


    }
}
