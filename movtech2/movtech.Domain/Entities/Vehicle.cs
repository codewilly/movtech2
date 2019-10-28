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
            set => _year = SetYear(value);
        }

        private float _quilometers { get; set; }

        public float Quilometers
        {
            get => _quilometers;
            set => _quilometers = SetQuilometers(value);
        }


        public FuelType FuelType { get; set; }

        public VehicleType VehicleType { get; set; }

        public bool InGarage { get; set; } = true;

        public VehicleStatus Status { get; set; } = VehicleStatus.Disponivel;



        #region Contructor

        protected Vehicle() {} // EF Ctor
        
        public Vehicle(int year)
        {
            _year = SetYear(year);
        }

        #endregion

        #region Methods

        public int SetYear(int year)
        {
            int _maxYear = DateTime.Now.Year + 1;
            return (year > 1990 && year < _maxYear) ? year : throw new ArgumentOutOfRangeException($"O ano deve estar entre 1990 e {_maxYear}");
        }

        public float SetQuilometers(float kms)
        {
            if (kms < Quilometers)
            {
                throw new ArgumentException("A nova quilometragem deve ser maior ou igual a quilometragem atual!");
            }

            return kms;
        }

        #endregion


    }
}
