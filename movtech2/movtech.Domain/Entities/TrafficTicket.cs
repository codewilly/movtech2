using movtech.Domain.Entities.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class TrafficTicket : Address
    {
        public int Id { get; set; }

        public Driver Driver { get; set; }

        public Vehicle Vehicle { get; set; }

        public DateTime TrafficTicketDate { get; set; }

        public DateTime BilletExpiration { get; set; }

        public DateTime? PaymentDate { get; set; }

        public decimal Cost { get; set; }

        public int Points { get; private set; }
        public TrafficTicket()
        {

        }
        public TrafficTicket(Driver driver, Vehicle vehicle, DateTime trafficTicketDate, DateTime billetExpiration, DateTime? paymentDate, decimal cost, int points, TrafficTickeLevel level, string description, bool wasPaid, string cEP, string street, int number, string neighborhood, string city, UF uF) :base(cEP,street,number,neighborhood,city,uF)
        {
            Driver = driver;
            Vehicle = vehicle;
            TrafficTicketDate = trafficTicketDate;
            BilletExpiration = billetExpiration;
            PaymentDate = paymentDate;
            Cost = cost;
            Points = points;
            Level = level;
            Description = description;
            WasPaid = wasPaid;
        }

        private TrafficTickeLevel _level { get; set; }

        public TrafficTickeLevel Level
        {
            get => _level;
            set => _level = SetTrafficTickeLevel(value);
        }

        public string Description { get; set; }

        public bool WasPaid { get; set; }


        public string Validate()
        {
            if (Driver == null)
            {
                return "Motorista não encontrado";
            }
          
            if (Vehicle == null)
            {
                return "Veículo não encontrado";
            }

            if (TrafficTicketDate > DateTime.Now)
            {
                return "Data da infração inválida";
            }

            return "ok";
        }

        public void Pay()
        {
            if (WasPaid)
            {
                throw new InvalidOperationException("Esta multa já se encontra paga!");
            }

            PaymentDate = DateTime.Now;
            WasPaid = true;

        }


        public TrafficTickeLevel SetTrafficTickeLevel(TrafficTickeLevel level)
        {

            switch (level)
            {
                case TrafficTickeLevel.Leve:
                    Points = 3;
                    break;

                case TrafficTickeLevel.Media:
                    Points = 4;
                    break;

                case TrafficTickeLevel.Grave:
                    Points = 5;
                    break;

                case TrafficTickeLevel.Gravissima:
                    Points = 7;
                    break;

            }

            return level;
        }
    }
}
