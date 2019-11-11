﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace movtech.Domain.Contracts.Driver
{
    public class CreateDriverRequest : AddressRequest
    {
        [Required(ErrorMessage = "Preencha este campo!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Informe um CPF no formato  000.000.000-00")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string CNH { get; set; }

        [Required(ErrorMessage = "Preencha este campo!")]
        public string CNHCategory { get; set; }
    }
}