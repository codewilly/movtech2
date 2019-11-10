using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.ViaCEP
{
    public class SearchCepResponse
    {
        public string Cep { get; set; }

        public string Logradouro { get; set; }        

        public string Bairro { get; set; }

        public string Localidade { get; set; } // Cidade

        public string UF { get; set; }

        // Não usados:

        public string Complemento { get; set; }

        public string Unidade { get; set; }

        public string IBGE { get; set; }

        public string GIA { get; set; }
    }
}

