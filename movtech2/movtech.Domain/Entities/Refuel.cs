using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Refuel
    {
        public int Id { get; set; }

        public double TotalValue { get; set; }

        public double LiterValue { get; set; }

        public float Liters { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime RefuelDate { get; set; }

        public Vehicle Vehicle { get; set; }

        public Driver Driver { get; set; }
        
        public GasStation GasStation { get; set; }


        public string Validate()
        {
            var _total =  Math.Round(LiterValue * Liters,2);
            if (_total != TotalValue)
            {
                return "O valor total não é bate com a quantidade de litros * preço do litro.";
            }

            if (Vehicle == null)
            {
                return "Veículo não encontrado";
            }
            
            if (Driver == null)
            {
                return "Veículo não encontrado";
            }

            if (GasStation == null)
            {
                return "Posto de gasolina não encontrado";
            }


            return "ok";
        }

    }
}
