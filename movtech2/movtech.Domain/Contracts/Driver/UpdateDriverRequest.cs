using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace movtech.Domain.Contracts.Driver
{
    public class UpdateDriverRequest : AddressRequest
    {
        [Required(ErrorMessage = "Preencha este campo!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [MaxLength(5, ErrorMessage = "Deve conter atés {1} caracteres")]
        public string CNHCategory { get; set; }
    
    }
}
