using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
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
        public Refuel()
        {

        }

        public Refuel(decimal totalValue, decimal literValue, float liters, FuelType fuelType, DateTime refuelDate, Vehicle vehicle, Driver driver, GasStation gasStation)
        {
            TotalValue = totalValue;
            LiterValue = literValue;
            Liters = liters;
            FuelType = fuelType;
            RefuelDate = refuelDate;
            Vehicle = vehicle;
            Driver = driver;
            GasStation = gasStation;
        }
    }
}
