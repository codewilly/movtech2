﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace movtech.Domain.Contracts.Refuel
{
    public class CreateGasStationRequest : AddressRequest
    {
        [Required(ErrorMessage = "CNPJ obrigatório")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "Deve conter {1} caracteres")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Informe um CNPJ no formato 00.000.000/0000-00")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [MaxLength(150, ErrorMessage = "Deve conter no máximo {1} caracteres")]
        public string Name { get; set; }
    }
}