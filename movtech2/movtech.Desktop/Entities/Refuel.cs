using movtech.Desktop.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Desktop.Entities
{
    public class Refuel
    {
        public int Id { get; set; }

        public decimal TotalValue { get; set; }

        public decimal LiterValue { get; set; }

        public float Liters { get; set; }

        public FuelType FuelType { get; set; }

        public DateTime RefuelDate { get; set; }

        public Vehicle Vehicle { get; set; }

        public Driver Driver { get; set; }
        
        public GasStation GasStation { get; set; }


        public string Validate()
        {
            decimal _total =  Math.Round(LiterValue * (decimal)Liters,2);
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
