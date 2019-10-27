using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }
        
        public string LicensePlate { get; set; }

        public string Renavam { get; set; }

        private int _year { get; set; }

        public int Year
        {
            get => _year;
            private set => _year = SetYear(value);
        }

        public float Quilometers { get; set; }

        public FuelType FuelType { get; set; }

        public bool InGarage { get; set; } = true;

        public int SetYear(int year)
        {
            int _maxYear = DateTime.Now.Year + 1;
            return (year > 1990 && year < _maxYear) ? year : throw new ArgumentOutOfRangeException($"O ano deve estar entre 1990 e {_maxYear}");
        }
    }
}
