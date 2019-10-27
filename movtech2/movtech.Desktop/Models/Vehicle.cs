using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Desktop.Models
{
    class Vehicle
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int MinYear { get; set; }
        public int MaxYear { get; set; }
        public int BrandId { get; set; }
        public string VehicleType { get; set; }
        public string FuelType { get; set; }



        public Vehicle(int id, string modelName, int minYear, int maxYear, int brandId, string vehicleType, string fuelType)
        {
            Id = id;
            ModelName = modelName;
            MinYear = minYear;
            MaxYear = maxYear;
            BrandId = brandId;
            VehicleType = vehicleType;
            FuelType = fuelType;
        }

        public static List<Vehicle> GetAll()
        {
            List<Vehicle> carlist = new List<Vehicle>();

            carlist.Add(new Vehicle(1, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(2, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(3, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(4, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(5, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(6, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(7, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(8, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(9, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(10, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(11, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(12, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(13, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(14, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(15, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(10, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(11, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(12, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(13, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(14, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));
            carlist.Add(new Vehicle(15, "Gol", 1999, 2000, 10, "Esportivo", "Gasolina"));

            return carlist;

        }
    }
}
